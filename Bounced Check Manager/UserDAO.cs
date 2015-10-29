using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bounced_Check_Manager
{
    class UserDAO
    {
        public static List<User> listAll()
        {
            List<User> users = new List<User>();
            SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            // Possible columns: sid, status, createdate, updatedate, accdate, totcpu, totio, spacelimitl, timelimit, resultlimit, name, dbname, password, denylogin, hasaccess, instname, isntgroup, isntuser, sysadmin, securityadmin, serveradmin, setupadmin, processadmin, diskadmin,dbcreator, bulkadmin, loginname
            cmd.CommandText = @"SELECT sid, status, name, createdate, updatedate, accdate FROM sys.syslogins where password IS NOT NULL and hasaccess = 1 and isntname = 0 and not name like '##%##' and name not like 'sa';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            int test = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    test++;
                    //int sid = reader.GetInt16(0);
                    int sid = 0;
                    int status = reader.GetInt16(1);
                    String name = reader.GetString(2);
                    DateTime createdate = reader.GetDateTime(3);
                    DateTime updatedate = reader.GetDateTime(4);
                    DateTime accdate = reader.GetDateTime(5);
                    users.Add(new User(sid, status, name, createdate, updatedate, accdate));
                }
            }
            reader.Close();
            sqlConnection1.Close();
            return users;
        }

        // Create User <user>
        public static bool create(String username, String password)
        {
            SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
            SqlCommand cmd = new SqlCommand();

            // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
            cmd.CommandText = @"CREATE LOGIN {UNAME} WITH PASSWORD = '{PASSWORD}';".Replace("{UNAME}", username).Replace("{PASSWORD}", password);


            cmd.Connection = sqlConnection1;
            cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
            cmd.Parameters.Add("{Password}", SqlDbType.VarChar);
            cmd.Parameters["{UNAME}"].Value = username;
            cmd.Parameters["{Password}"].Value = password;

            sqlConnection1.Open();

            int result = cmd.ExecuteNonQuery();
            // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
            cmd.CommandText = @"EXEC master..sp_addsrvrolemember @loginame = N'{UNAME}', @rolename = N'sysadmin';".Replace("{UNAME}", username);
            cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
            cmd.Parameters["{UNAME}"].Value = username;
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            return result > 0;
        }

        public static bool delete(User user)
        {
            SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
            SqlCommand cmd = new SqlCommand();

            // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
            cmd.CommandText = @"DROP LOGIN {UNAME};".Replace("{UNAME}", user.name);

            cmd.Connection = sqlConnection1;
            //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
            //cmd.Parameters["{UNAME}"].Value = user.name;
            sqlConnection1.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection1.Close();
            return result == -1;
        }
    }
}

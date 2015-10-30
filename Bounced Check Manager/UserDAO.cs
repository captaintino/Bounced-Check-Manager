using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_Data_Layer
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
                cmd.CommandText = @"SELECT sl.sid, sl.status, sl.name, sl.createdate, sl.updatedate, sl.accdate FROM sys.syslogins sl
                                    join sys.sql_logins sql on sl.sid=sql.sid
where sql.is_disabled = 0 and sl.password IS NOT NULL and sl.hasaccess = 1 and sl.isntname = 0 and not sl.name like '##%##' and sl.name not like 'sa';";
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
                //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                //cmd.Parameters.Add("{Password}", SqlDbType.VarChar);
                //cmd.Parameters["{UNAME}"].Value = username;
                //cmd.Parameters["{Password}"].Value = password;

                sqlConnection1.Open();

                int result = cmd.ExecuteNonQuery();
                // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
                cmd.CommandText = @"EXEC master..sp_addsrvrolemember @loginame = N'{UNAME}', @rolename = N'sysadmin';".Replace("{UNAME}", username);
                //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                //cmd.Parameters["{UNAME}"].Value = username;
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                return result == -1;
            }

            public static bool delete(User user)
            {
                SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                SqlCommand cmd = new SqlCommand();

                // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
                cmd.CommandText = @"ALTER LOGIN {UNAME} DISABLE;".Replace("{UNAME}", user.name);

                cmd.Connection = sqlConnection1;
                //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                //cmd.Parameters["{UNAME}"].Value = user.name;
                sqlConnection1.Open();
                int result = cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                return result == -1;
            }

            public static bool changePasswordAdmin(User user, String password)
            {
                SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                SqlCommand cmd = new SqlCommand();

                // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
                cmd.CommandText = @"ALTER LOGIN {UNAME} WITH PASSWORD = '{PASSWORD}';".Replace("{UNAME}", user.name).Replace("{PASSWORD}", password);

                cmd.Connection = sqlConnection1;
                //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                //cmd.Parameters["{UNAME}"].Value = user.name;
                sqlConnection1.Open();
                int result = cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                return result == -1;
            }

            public static bool changePasswordUser(User user, String oldPassword, String password)
            {
                SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                SqlCommand cmd = new SqlCommand();

                // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
                cmd.CommandText = @"ALTER LOGIN {UNAME} WITH PASSWORD = '{PASSWORD}' OLD_PASSWORD = '{OLDPASSWORD}';".Replace("{UNAME}", user.name).Replace("{PASSWORD}", password).Replace("{OLDPASSWORD}",oldPassword);

                cmd.Connection = sqlConnection1;
                //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                //cmd.Parameters["{UNAME}"].Value = user.name;
                sqlConnection1.Open();
                int result = cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                return result == -1;
            }

            public static User find(String username)
            {
                User user = null;
                SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                // Possible columns: sid, status, createdate, updatedate, accdate, totcpu, totio, spacelimitl, timelimit, resultlimit, name, dbname, password, denylogin, hasaccess, instname, isntgroup, isntuser, sysadmin, securityadmin, serveradmin, setupadmin, processadmin, diskadmin,dbcreator, bulkadmin, loginname
                cmd.CommandText = @"SELECT sl.sid, sl.status, sl.name, sl.createdate, sl.updatedate, sl.accdate FROM sys.syslogins sl where name like '{UNAME}';".Replace("{UNAME}", username);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    //int sid = reader.GetInt16(0);
                    int sid = 0;
                    int status = reader.GetInt16(1);
                    String name = reader.GetString(2);
                    DateTime createdate = reader.GetDateTime(3);
                    DateTime updatedate = reader.GetDateTime(4);
                    DateTime accdate = reader.GetDateTime(5);
                    user = new User(sid, status, name, createdate, updatedate, accdate);
                }
                reader.Close();
                sqlConnection1.Close();
                return user;

            }

            public static bool UnitTest()
            {
                Debug.Assert(create("UNITTESttttt1", "PasswordPassingTest123!"));
                List<User> u = listAll();
                Debug.Assert(u.Count > 0);
                Debug.Assert(delete(u[u.Count - 1]));

                return true;
            }
        }
    }
}
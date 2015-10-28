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

            // Possible columns: uid, status, name, sid, roles, createdate, updatedate, altuid, password, gid, environ, hasdbaccess, islogin, isntname, isntgroup, isntuser, issqluser, isaliased, issqlrole, isapprole
            cmd.CommandText = @"SELECT uid, status, name, roles, createdate, updatedate, altuid, gid, islogin FROM sys.sysusers";
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
                    int uid = reader.GetInt16(0);
                    int status = reader.GetInt16(1);
                    String name = reader.GetString(2);
                    var roles = reader.GetSqlBinary(3);
                    // String roles = reader.GetString(3);
                    DateTime createdate = reader.GetDateTime(4);
                    DateTime updatedate = reader.GetDateTime(5);
                    var nu = reader.GetValue(6);
                    var nut = nu.GetType();
                    int altuid = (!(nu is System.DBNull)) ? reader.GetInt16(6) : -1;
                    int gid = reader.GetInt16(7);
                    int islogin = reader.GetInt32(8);
                    if (islogin > 0)
                    {
                        users.Add(new User(uid, status, name, roles.ToString(), createdate, updatedate, altuid, gid, islogin));
                    }
                }
            }
            reader.Close();
            sqlConnection1.Close();
            return users;
        }

        // Create User <user>
        public static bool create(Check check)
        {
            return false;
        }
    }
}

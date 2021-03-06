﻿using System;
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
            enum PasswordCategories { Capital, Lower, Number, Special };
            // Get list of all of the Users
            public static List<User> listAll()
            {
                try
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
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
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
                catch (Exception ex)
                {
                    return new List<User>();
                }
            }

            // Create User <user> on database
            public static bool create(String username, String password, bool supervisor)
            {
                try
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
                    if (supervisor)
                    {
                        cmd.CommandText = @"EXEC master..sp_addsrvrolemember @loginame = N'{UNAME}', @rolename = N'bulkadmin';".Replace("{UNAME}", username);
                        //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                        //cmd.Parameters["{UNAME}"].Value = username;
                        cmd.ExecuteNonQuery();
                    }

                    sqlConnection1.Close();
                    return result == -1;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            // Mark User <user> as disabled on database
            public static bool delete(User user)
            {
                try
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
                catch (Exception ex)
                {
                    return false;
                }
            }

            // Changes password of <user> to <password> in admin mode
            public static bool changePasswordAdmin(User user, String password)
            {
                try
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
                catch (Exception ex)
                {
                    return false;
                }
            }

            // Changes password of <user> to <password> using <oldPassword> for confirmation
            public static bool changePasswordUser(User user, String oldPassword, String password)
            {
                try
                {
                    SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                    SqlCommand cmd = new SqlCommand();

                    // TODO Figure out how to use parameters instead of direct replacement (DANGEROUS!!!!)
                    cmd.CommandText = @"ALTER LOGIN {UNAME} WITH PASSWORD = '{PASSWORD}' OLD_PASSWORD = '{OLDPASSWORD}';".Replace("{UNAME}", user.name).Replace("{PASSWORD}", password).Replace("{OLDPASSWORD}", oldPassword);

                    cmd.Connection = sqlConnection1;
                    //cmd.Parameters.Add("{UNAME}", SqlDbType.VarChar);
                    //cmd.Parameters["{UNAME}"].Value = user.name;
                    sqlConnection1.Open();
                    int result = cmd.ExecuteNonQuery();
                    sqlConnection1.Close();
                    return result == -1;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            // Find User with name of <username>
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

            // Attempt to login to server with <username> and <password> and update the relevant global variables <username> and <connectionString>
            public static bool login(string username, string password)
            {
                // Check if valid login
                String connectionString = "Data Source=CPSLABSERVER\\TEAMPENGUIN;Initial Catalog=TeamPenguin;Persist Security Info=True;User ID=" + username + ";Password=" + password;
                DataClasses1DataContext database = new DataClasses1DataContext(connectionString);
                if (!database.DatabaseExists())
                {
                    return false;
                }
                // set globals
                Globals.connectionString = connectionString;
                Globals.username = username;
                // check if supervisor
                try
                {
                    SqlConnection sqlConnection1 = new SqlConnection(Globals.connectionString);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = @"SELECT bulkadmin from sys.syslogins where name = '{UNAME}';".Replace("{UNAME}", username);
                    cmd.Connection = sqlConnection1;
                    sqlConnection1.Open();
                    // set globals
                    Globals.isSupervisor = (1 == (int)cmd.ExecuteScalar());
                    sqlConnection1.Close();
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }

            public static bool validatePassword(String password)
            {
                if (password.Length < 8)
                {
                    return false;
                }
                HashSet<PasswordCategories> set = new HashSet<PasswordCategories>();
                foreach (Char c in password)
                {
                    if (Char.IsDigit(c))
                    {
                        set.Add(PasswordCategories.Number);
                    }
                    else if (Char.IsLower(c))
                    {
                        set.Add(PasswordCategories.Lower);
                    }
                    else if (Char.IsUpper(c))
                    {
                        set.Add(PasswordCategories.Capital);
                    }
                    else if (Char.IsSymbol(c))
                    {
                        set.Add(PasswordCategories.Special);
                    }
                }
                return set.Count >= 3;
            }

            public static bool UnitTest()
            {
                Debug.Assert(create("UNITTESttttt1", "PasswordPassingTest123!", true));
                List<User> u = listAll();
                Debug.Assert(u.Count > 0);
                User user = u[u.Count - 1];
                Debug.Assert(delete(user));
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


                return true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.DomainServices.Server;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace Bounced_Check_Manager
{
    static class AccountDAO
    {

        // Get list of all of the Accounts in the database
        public static List<Account> LoadAll()
        {
            List<Account> list = new List<Account>();
            using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
            {
                var query = from a in database.Accounts
                            select a;

                foreach (var a in query)
                {
                    list.Add(a);
                }
            }
            return list;
        }

        // Update Account <acc>
        public static bool update(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
            {
                var query = from a in database.Accounts
                            // Assuming the accountNumber is enough of an identifier.
                            // Additional 'where' clauses can be added if necessary.
                            where (a.AccountID == acc.AccountID)
                            select a;
                // It seems to me that a single account renders the foreach unnecessary. However, I can't
                // find another way to get the variable 'a' from 'query'.
                foreach (var a in query)
                {
                    a.AccountAddress = acc.AccountAddress;
                    a.AccountFirstName = acc.AccountFirstName;
                    a.AccountLastName = acc.AccountLastName;
                    a.AccountNum = acc.AccountNum;
                    a.AccountPhoneNum = acc.AccountPhoneNum;
                    a.AccountRoutingNum = acc.AccountRoutingNum;
                    a.BankID = acc.BankID;
                }
                try
                {
                    database.SubmitChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        // Delete Account <acc>
        public static bool delete(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
            {
                var query = from a in database.Accounts
                            where (a.AccountID == acc.AccountID)
                            select a;
                // It seems to me that a single account renders the foreach unnecessary. However, I can't
                // find another way to get the variable 'a' from 'query'.
                foreach (var a in query)
                {
                    database.Accounts.DeleteOnSubmit(a);
                    try
                    {
                        database.SubmitChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
                return false;
            }
        }

        // Create Account <acc>
        public static bool create(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
            {
                database.Accounts.InsertOnSubmit(acc);
                try
                {
                    database.SubmitChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        // Find first account having routing number of <routingNum> and account number of <accountNum>
        public static Account find(int routingNum, int accountNum)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
            {
                var query = from a in database.Accounts
                            where (a.AccountRoutingNum == routingNum && a.AccountNum == accountNum)
                            select a;
                foreach (var a in query)
                {
                    // Look at the Bank member so LINQ doesn't trim it from the Account object...
                    var s = a.Bank;
                    return a;
                }
                return null;
            }
        }

        // Return a list of all accounts matching the information given.
        // If a string is given as "" (empty string), that parameter is ignored.
        public static List<Account> findAny(string accNum, string accFirstName, string accLastName, string accPhoneNum, string accAddress, string accRoutNum)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
            {
                accFirstName = "%" + accFirstName + "%";
                accLastName = "%" + accLastName + "%";
                accAddress = "%" + accAddress + "%";
                IQueryable<Account> query;
                if ((accNum != "") && (accRoutNum != "") && (accPhoneNum != ""))
                {
                    int accNumber = Convert.ToInt32(accNum);
                    int accRoutNumber = Convert.ToInt32(accRoutNum);
                    int accPhoneNumber = Convert.ToInt32(accPhoneNum);
                    query = from a in database.Accounts
                            where (a.AccountNum == accNumber && a.AccountRoutingNum == accRoutNumber && a.AccountPhoneNum == accPhoneNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else if ((accNum == "") && (accRoutNum != "") && (accPhoneNum != ""))
                {
                    int accRoutNumber = Convert.ToInt32(accRoutNum);
                    int accPhoneNumber = Convert.ToInt32(accPhoneNum);
                    query = from a in database.Accounts
                            where (a.AccountRoutingNum == accRoutNumber && a.AccountPhoneNum == accPhoneNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else if ((accNum != "") && (accRoutNum == "") && (accPhoneNum != ""))
                {
                    int accNumber = Convert.ToInt32(accNum);
                    int accPhoneNumber = Convert.ToInt32(accPhoneNum);
                    query = from a in database.Accounts
                            where (a.AccountNum == accNumber && a.AccountPhoneNum == accPhoneNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else if ((accNum != "") && (accRoutNum != "") && (accPhoneNum == ""))
                {
                    int accNumber = Convert.ToInt32(accNum);
                    int accRoutNumber = Convert.ToInt32(accRoutNum);
                    query = from a in database.Accounts
                            where (a.AccountNum == accNumber && a.AccountRoutingNum == accRoutNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else if ((accNum != "") && (accRoutNum == "") && (accPhoneNum == ""))
                {
                    int accNumber = Convert.ToInt32(accNum);
                    query = from a in database.Accounts
                            where (a.AccountNum == accNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else if ((accNum == "") && (accRoutNum != "") && (accPhoneNum == ""))
                {
                    int accRoutNumber = Convert.ToInt32(accRoutNum);
                    query = from a in database.Accounts
                            where (a.AccountRoutingNum == accRoutNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else if ((accNum == "") && (accRoutNum == "") && (accPhoneNum != ""))
                {
                    int accPhoneNumber = Convert.ToInt32(accPhoneNum);
                    query = from a in database.Accounts
                            where (a.AccountPhoneNum == accPhoneNumber &&
                                   SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }
                else
                {
                    query = from a in database.Accounts
                            where (SqlMethods.Like(a.AccountFirstName, accFirstName) &&
                                   SqlMethods.Like(a.AccountLastName, accLastName) &&
                                   SqlMethods.Like(a.AccountAddress, accAddress))
                            select a;
                }

                List<Account> accounts = new List<Account>();

                foreach (var a in query)
                {
                    // Look at the Bank member so LINQ doesn't trim it from the Account object...
                    var s = a.Bank;
                    accounts.Add(a);
                }

                return accounts;
            }
        }
    }
}

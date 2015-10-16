using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.DomainServices.Server;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void update(Account acc)
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
                    // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
                    a.AccountID = acc.AccountID;
                    a.AccountFirstName1 = acc.AccountFirstName1;
                    a.AccountAddress = acc.AccountAddress;
                    a.AccountRoutingNum = acc.AccountRoutingNum;
                }
                try
                {
                    database.SubmitChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error writing to the database: \n\n" + e);
                }
            }
        }

        // Delete Account <acc>
        public static void delete(Account acc)
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
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("There was an error writing to the database: \n\n" + e);
                    }
                }
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
                    var s = a.Bank;
                    return a;
                }
                return null;
            }
        }
    }
}

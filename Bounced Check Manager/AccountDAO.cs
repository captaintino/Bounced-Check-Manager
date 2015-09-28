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

        public static bool connectToDB(String user, String pass)
        {


            return true;
        }

        public static List<Account> LoadAll()
        {
            List<Account> list = new List<Account>();
            // TODO: Connect to a network DB - should be able to modify the .dbml file to point to a
            // network DB.
            // TODO: Either move the DB connection to the connectToDB method or eliminate it the method.
            using (DataClasses1DataContext database = new DataClasses1DataContext())
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

        public static void update(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext())
            {
                var query = from a in database.Accounts
                            // Assuming the accountNumber is enough of an identifier.
                            // Additional 'where' clauses can be added if necessary.
                            where (a.AccNo == acc.AccNo)
                            select a;
                // It seems to me that a single account renders the foreach unnecessary. However, I can't
                // find another way to get the variable 'a' from 'query'.
                foreach (var a in query)
                {
                    // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
                    a.AccNo = acc.AccNo;
                    a.AccName = acc.AccName;
                    a.AccAddress = acc.AccAddress;
                    a.AccRoutNo = acc.AccRoutNo;
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

        public static void delete(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext())
            {
                var query = from a in database.Accounts
                            where (a.AccID == acc.AccID)
                            select a;
                // It seems to me that a single account renders the foreach unnecessary. However, I can't
                // find another way to get the variable 'a' from 'query'.
                foreach (var a in query)
                {
                    // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
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

        public static void create(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext())
            {
                database.Accounts.InsertOnSubmit(acc);
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
}

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
        // USING DOTCONNECT EXPRESS FOR MYSQL
        //private bla;


        public static bool connectToDB(String user, String pass)
        {


            return true;
        }

        public static List<Account> LoadAll()
        {
            List<Account> list = new List<Account>();
            // TODO: Connect to a network DB - should be able to modify the .dbml file to point to a
            // network DB.
            // TODO: Either move the DB connection to the connectToDB method or eliminate it.
            using (DataClasses1DataContext database = new DataClasses1DataContext())
            {
                var query = from a in database.Accounts
                            select a;

                foreach (var a in query)
                {
                    list.Add(new Account(a.AccID, a.AccName, a.AccAddress, a.AccRoutNo, a.AccNo));
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
                            where (a.AccNo == acc.accountNumber)
                            select a;
                // It seems to me that a single account renders the foreach unnecessary. However, I can't
                // find another way to get the variable 'a' from 'query'.
                foreach (var a in query)
                {
                    // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
                    a.AccNo = acc.accountNumber;
                    a.AccName = acc.name;
                    a.AccAddress = acc.address;
                    a.AccRoutNo = acc.routingNumber;
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
            // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
            /*String query = "UPDATE Account set name=" + acc.name + 
                                              ", address=" + acc.address + 
                                              ", routingNumber=" + acc.routingNumber + 
                                              ", accountNumber=" + acc.accountNumber + 
                                              " WHERE id=" + acc.id + ";" ;*/
        }

        public static void delete(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext())
            {
                var query = from a in database.Accounts
                            where (a.AccID == acc.id)
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
            // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
            /*String query = "DELETE FROM Account WHERE name like " + acc.name + 
                                              " AND address like " + acc.address + 
                                              " AND routingNumber=" + acc.routingNumber + 
                                              " AND accountNumber=" + acc.accountNumber + 
                                              " AND id=" + acc.id + ";"; */
        }

        public static Account create(Account acc)
        {
            using (DataClasses1DataContext database = new DataClasses1DataContext())
            {
                acc.AccID = acc.id;
                acc.AccName = acc.name;
                acc.AccNo = acc.accountNumber;
                acc.AccAddress = acc.address;
                acc.AccRoutNo = acc.routingNumber;
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
            // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
            /*String query = "INSERT INTO Account (name, address, routingNumber, accountNumber) VALUES ("+ 
                                              acc.name + "," + acc.address + "," + acc.routingNumber + "," + acc.accountNumber + ");"; */

            return acc; // ??????
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            return list;
        }

        public static void update(Account acc)
        {
            // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
            String query = "UPDATE Account set name=" + acc.name + 
                                              ", address=" + acc.address + 
                                              ", routingNumber=" + acc.routingNumber + 
                                              ", accountNumber=" + acc.accountNumber + 
                                              " WHERE id=" + acc.id + ";" ;
        }

        public static void delete(Account acc)
        {
            // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
            String query = "DELETE FROM Account WHERE name like " + acc.name + 
                                              " AND address like " + acc.address + 
                                              " AND routingNumber=" + acc.routingNumber + 
                                              " AND accountNumber=" + acc.accountNumber + 
                                              " AND id=" + acc.id + ";"; 
        }

        public static Account create(Account acc)
        {
            // DANGEROUS DIRECT DATA INSERTIONS. NEED CLEANING
            String query = "INSERT INTO Account (name, address, routingNumber, accountNumber) VALUES ("+ 
                                              acc.name + "," + acc.address + "," + acc.routingNumber + "," + acc.accountNumber + ");"; 

            var resultingInt = 0;
            acc.id = resultingInt;
            return acc; // ??????
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_Data_Layer
    {
        class BankDAO
        {
            // Create <bank> in database
            public static bool create(Bank bank)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    database.Banks.InsertOnSubmit(bank);
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

            // Delete Bank <bank> from database
            public static bool delete(Bank bank)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Banks
                                where (a.BankID == bank.BankID)
                                select a;
                    // It seems to me that a single account renders the foreach unnecessary. However, I can't
                    // find another way to get the variable 'a' from 'query'.
                    foreach (var a in query)
                    {
                        database.Banks.DeleteOnSubmit(a);
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

            // Find first bank having routing number of <routingNum> in database
            public static Bank find(int routingNum)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Banks
                                where (a.BankRoutingNum == routingNum)
                                select a;
                    foreach (var a in query)
                    {
                        return a;
                    }
                    return null;
                }
            }

            public static bool UnitTest()
            {
                return true;
            }
        }
    }
}
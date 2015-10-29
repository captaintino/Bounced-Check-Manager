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
        class CheckDAO
        {
            // Create Check <check>
            public static bool create(Check check)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    database.Checks.InsertOnSubmit(check);
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

            public static List<Check> getChecksFromAcc(int accID)
            {
                List<Check> result = new List<Check>();
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Checks
                                where (a.AccountID == accID)
                                select a;

                    foreach (var a in query)
                    {
                        // Look at the Bank member so LINQ doesn't trim it from the Check object...
                        var s = a.Bank;
                        result.Add(a);
                    }
                }
                return result;
            }

            public static bool UnitTest()
            {
                //Account acc = new Account();
                //acc.AccountAddress = "TEST";
                //acc.AccountFirstName = "TEST";
                //acc.AccountLastName = "TEST";
                //acc.AccountNum = 0;
                //acc.AccountPhoneNum = 0;
                //acc.AccountRoutingNum = 0;
                //acc.BankID = 0;
                //Debug.Assert(create(acc));
                //Debug.Assert(LoadAll().Count > 0);

                return true;
            }
        }
    }
}
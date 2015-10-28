using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounced_Check_Manager
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
    }
}

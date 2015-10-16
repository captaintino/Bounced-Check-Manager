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
    }
}

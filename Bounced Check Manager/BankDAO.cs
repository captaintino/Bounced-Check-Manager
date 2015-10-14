using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounced_Check_Manager
{
    class BankDAO
    {

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
    }
}

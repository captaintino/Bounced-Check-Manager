using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_Data_Layer
    {
        class UnitTest
        {
            public static bool run()
            {
                AccountDAO.UnitTest();
                BankDAO.UnitTest();
                CheckDAO.UnitTest();
                StoreDAO.UnitTest();
                UserDAO.UnitTest();
                return true;
            }
        }
    }
}

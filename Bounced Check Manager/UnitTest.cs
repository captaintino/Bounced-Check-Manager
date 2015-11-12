using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_Data_Layer
    {
        class UnitTest
        {
            public static bool run()
            {
                // Incomplete (dependant on other systems)
                AccountDAO.UnitTest();
                BankDAO.UnitTest();
                CheckDAO.UnitTest();
                // Self contained
                StoreDAO.UnitTest();
                UserDAO.UnitTest();

                // Full cycle unit test
                // Bank Creation/find
                Bank bank = new Bank();
                bank.BankAddress = "TEST123";
                bank.BankName = "TEST123";
                bank.BankRoutingNum = Int32.MaxValue;
                Debug.Assert(BankDAO.create(bank));
                bank = BankDAO.find(Int32.MaxValue);
                Debug.Assert(bank != null && bank.BankName == "TEST123");
                // Bank update
                // ...

                // Account Creation
                Account acc = new Account();
                acc.AccountAddress = "TEST123";
                acc.AccountFirstName = "TEST123";
                acc.AccountLastName = "TEST123";
                acc.AccountNum = Int32.MaxValue;
                acc.AccountPhoneNum = 0;
                acc.AccountRoutingNum = Int32.MaxValue;
                acc.BankID = bank.BankID;
                Debug.Assert(AccountDAO.create(acc));
                acc = AccountDAO.find(Int32.MaxValue, Int32.MaxValue);
                Debug.Assert(acc != null && acc.AccountAddress == "TEST123");
                // Account update
                // ...

                // Store Creation
                Store store = new Store();
                store.StoreAddress = "TEST123";
                store.StoreName = "TEST123";
                store.StoreNum = Int32.MaxValue;
                store.StoreServiceCharge = Int32.MaxValue;
                StoreDAO.create(store);
                store = StoreDAO.find(Int32.MaxValue);
                Debug.Assert(store != null && store.StoreName == "TEST123");
                // Store update
                // ...

                // Check Creation
                Check check = new Check();
                check.AccountID = acc.AccountID;
                check.BankID = bank.BankID;
                check.StoreID = Int32.MaxValue;
                check.CheckAmount = float.MaxValue;
                check.CheckAmountOwed = float.MaxValue;
                check.CheckCashierID = Int32.MaxValue;
                check.CheckDate = DateTime.MinValue;
                check.CheckDeleted = false;
                check.CheckNum = Int32.MaxValue;
                Debug.Assert(CheckDAO.create(check));
                var checks = CheckDAO.getChecksFromAcc(acc.AccountID);
                Debug.Assert(checks.Count > 0);
                // Check update
                // ...

                // Letter Creation
                // ...

                // Letter update
                // ...

                // Letter Deletion
                // ...

                // Check Deletion
                Debug.Assert(CheckDAO.delete(check));

                // Store Deletion
                Debug.Assert(StoreDAO.delete(store));

                // Account Deletion
                Debug.Assert(AccountDAO.delete(acc));

                // Bank Deletion
                Debug.Assert(BankDAO.delete(bank));



                return true;
            }
        }
    }
}

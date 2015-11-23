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

            // Update Check <check>
            public static bool update(Check check)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Checks
                                where (a.CheckID == check.CheckID)
                                select a;
                    foreach (var a in query)
                    {
                        a.CheckAmount = check.CheckAmount;
                        a.CheckAmountOwed = check.CheckAmountOwed;
                        a.CheckCashierID = check.CheckCashierID;
                        a.CheckDate = check.CheckDate;
                        a.CheckDeleted = check.CheckDeleted;
                        a.CheckNum = check.CheckNum;
                        a.CheckPaidDate = check.CheckPaidDate;
                    }
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

            public static bool markAsVoid(Check check)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Checks
                                where (a.CheckID == check.CheckID)
                                select a;
                    foreach (var a in query)
                    {
                        a.CheckDeleted = true;
                    }
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

            // Delete Check <check> from database
            public static bool delete(Check check)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from c in database.Checks
                                where (c.CheckID == check.CheckID)
                                select c;
                    // It seems to me that a single account renders the foreach unnecessary. However, I can't
                    // find another way to get the variable 'a' from 'query'.
                    foreach (var c in query)
                    {
                        database.Checks.DeleteOnSubmit(c);
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

            // Returns all checks in the database associated with <accId>
            public static List<Check> getChecksFromAcc(int accID)
            {
                List<Check> result = new List<Check>();
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Checks
                                where (a.AccountID == accID)
                                select a;

                    try
                    {
                        foreach (var a in query)
                        {
                            // Look at the Bank member so LINQ doesn't trim it from the Check object...
                            var s = a.Bank;
                            var t = a.Account;
                            result.Add(a);
                        }
                    }
                    catch (Exception e)
                    {
                        return new List<Check>();
                    }
                }
                return result;
            }
            // Returns all checks in the database associated with <accId> that do not have a paid date
            public static List<Check> getUnpaidChecksFromAcc(int accID)
            {
                List<Check> result = new List<Check>();
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Checks
                                where (a.AccountID == accID && a.CheckPaidDate == null)
                                select a;

                    try
                    {
                        foreach (var a in query)
                        {
                            // Look at the Bank member so LINQ doesn't trim it from the Check object...
                            var s = a.Bank;
                            var t = a.Account;
                            result.Add(a);
                        }
                    }
                    catch (Exception e)
                    {
                        return new List<Check>();
                    }
                }
                return result;
            }

            public static bool UnitTest()
            {
                return true;
            }
        }
    }
}
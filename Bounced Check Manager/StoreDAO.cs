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
        class StoreDAO
        {
            // Get list of all of the Stores in the database
            public static List<Store> LoadAll()
            {
                List<Store> list = new List<Store>();
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Stores
                                select a;

                    foreach (var a in query)
                    {
                        list.Add(a);
                    }
                }
                return list;
            }

            // Create Store <store>
            public static bool create(Store store)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    database.Stores.InsertOnSubmit(store);
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

            // Update Store <store>
            public static bool update(Store store)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Stores
                                where (a.StoreID == store.StoreID)
                                select a;
                    foreach (var a in query)
                    {
                        a.StoreNum = store.StoreNum;
                        a.StoreName = store.StoreName;
                        a.StoreAddress = store.StoreAddress;
                        a.StoreServiceCharge = store.StoreServiceCharge;
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

            // Find first active store having store number of <storeNum>
            public static Store find(int storeNum)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Stores
                                where (a.StoreNum == storeNum)
                                select a;
                    foreach (var a in query)
                    {
                        return a;
                    }
                    return null;
                }
            }

            // Delete Store <store> from database
            public static bool delete(Store store)
            {
                using (DataClasses1DataContext database = new DataClasses1DataContext(Globals.connectionString))
                {
                    var query = from a in database.Stores
                                where (a.StoreID == store.StoreID)
                                select a;
                    // It seems to me that a single account renders the foreach unnecessary. However, I can't
                    // find another way to get the variable 'a' from 'query'.
                    foreach (var a in query)
                    {
                        database.Stores.DeleteOnSubmit(a);
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

            public static bool UnitTest()
            {
                Debug.Assert(LoadAll().Count > 0);
                return true;
            }
        }
    }
}
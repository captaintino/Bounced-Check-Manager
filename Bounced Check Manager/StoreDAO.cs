﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
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
    }
}

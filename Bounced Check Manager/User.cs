using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
{
    public class User
    {
        public int sid;
        public int status;
        public String name;
        public DateTime createdate;
        public DateTime updatedate;
        public DateTime accdate;

        public User(int sidNew, int statusNew, String nameNew, DateTime createdateNew, DateTime updatedateNew, DateTime accdateNew)
        {
            sid = sidNew;
            status = statusNew;
            name = nameNew;
            createdate = createdateNew;
            updatedate = updatedateNew;
            accdate = accdateNew;
        }
    }
}

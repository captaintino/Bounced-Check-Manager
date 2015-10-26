using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
{
    public class User
    {
        public int uid;
        public int status;
        public String name;
        public String roles;
        public DateTime createdate;
        public DateTime updatedate;
        public int altuid;
        public int gid;
        public int islogin;

        public User(int uidNew, int statusNew, String nameNew, String rolesNew, DateTime createdateNew, DateTime updatedateNew, int altuidNew, int gidNew, int isloginNew)
        {
            uid = uidNew;
            status = statusNew;
            name = nameNew;
            roles = rolesNew;
            createdate = createdateNew;
            updatedate = updatedateNew;
            altuid = altuidNew;
            gid = gidNew;
            islogin = isloginNew;
        }
    }
}

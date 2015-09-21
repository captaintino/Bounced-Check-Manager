using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
{
    public partial class Account
    {
        public String name, address;
        public int routingNumber, accountNumber, id;

        public Account(int id, String name, String address, int routingNumber, int accountNumber)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.routingNumber = routingNumber;
            this.accountNumber = accountNumber;
        }
    }
}

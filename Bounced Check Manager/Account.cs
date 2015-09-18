using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounced_Check_Manager
{
    public class Account
    {
        public String name, address;
        public int routingNumber, accountNumber, id;

        public Account(String name, String address, int routingNumber, int accountNumber)
        {
            this.name = name;
            this.address = address;
            this.routingNumber = routingNumber;
            this.accountNumber = accountNumber;
        }
    }
}

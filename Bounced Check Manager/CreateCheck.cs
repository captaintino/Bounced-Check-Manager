using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounced_Check_Manager
{
    public partial class CreateCheck : Form
    {
        public CreateCheck()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RoutingNumberTxtBox.Text != "" && AccNumberTxtBox.Text != "")
            {
                Account a = AccountDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text), Convert.ToInt32(AccNumberTxtBox.Text));
                if (a != null)
                {
                    FNameTxtBox.Text = a.AccountFirstName1;
                    LNameTextBox.Text = a.AccountLastName;
                    AddressTxtBox.Text = a.AccountAddress;
                    //Bank b = a.Bank;
                    //BankAddressTxtBox.Text = b.BankAddress;
                    //BankNameTxtBox.Text = b.BankName;
                }
                else
                {
                    MessageBox.Show("No Account found");
                }
            }
            else
            {
                MessageBox.Show("Please insert routing number and account number");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created check");
            this.Close();
        }
    }
}

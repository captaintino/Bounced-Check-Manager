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
    public partial class updateAccount : Form
    {
        Account account = null;
        public updateAccount(Account acc)
        {
            InitializeComponent();
            this.account = acc;
            nameTextBox.Text = account.name;
            addressTextBox.Text = account.address;
            accountNumberTextBox.Text = account.accountNumber.ToString();
            routingNumberTextBox.Text = account.routingNumber.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && addressTextBox.Text != "" && routingNumberTextBox.Text != "" && accountNumberTextBox.Text != "")
            {
                int routing = 0;
                int accountNum = 0;
                try
                {
                    routing = Convert.ToInt32(routingNumberTextBox.Text);
                    accountNum = Convert.ToInt32(accountNumberTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid account or routing number");
                    return;
                }
                this.account.name = nameTextBox.Text;
                this.account.address = addressTextBox.Text;
                this.account.accountNumber = accountNum;
                this.account.routingNumber = routing;
                AccountDAO.update(this.account);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }
        }
    }
}

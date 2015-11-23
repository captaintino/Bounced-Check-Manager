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
    namespace Bounced_Check_Manager_UI_Layer
    {
        public partial class updateAccount : Form
        {
            List<Bank> banks = Bounced_Check_Manager_Data_Layer.BankDAO.LoadAll();
            Account account = null;
            public updateAccount(Account acc)
            {
                InitializeComponent();
                this.account = acc;
                firstNameTextBox.Text = account.AccountFirstName;
                lastNameTextBox.Text = account.AccountLastName;
                addressTextBox.Text = account.AccountAddress;
                accountNumberTextBox.Text = account.AccountNum.ToString();
                routingNumberTextBox.Text = account.AccountRoutingNum.ToString();
                phoneNumberTextBox.Text = account.AccountPhoneNum.ToString();

                int index = 0;
                for (int i = 0; i < banks.Count; i++)
                {
                    SelectBankCmb.Items.Add(Bounced_Check_Manager_Data_Layer.BankDAO.getBankString(banks[i]));
                    if (banks[i].BankID == account.BankID)
                    {
                        index = i;
                    }
                }
                SelectBankCmb.SelectedIndex = index;
            }

            private void submit_Click(object sender, EventArgs e)
            {
                if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && addressTextBox.Text != "" && routingNumberTextBox.Text != "" && accountNumberTextBox.Text != "")
                {
                    int routing = 0;
                    int accountNum = 0;
                    int phoneNum = 0;
                    try
                    {
                        routing = Convert.ToInt32(routingNumberTextBox.Text);
                        accountNum = Convert.ToInt32(accountNumberTextBox.Text);
                        phoneNum = Convert.ToInt32(phoneNumberTextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid account, routing or phone number");
                        return;
                    }
                    this.account.AccountFirstName = firstNameTextBox.Text;
                    this.account.AccountLastName = lastNameTextBox.Text;
                    this.account.AccountAddress = addressTextBox.Text;
                    this.account.AccountNum = accountNum;
                    this.account.AccountRoutingNum = routing;
                    this.account.AccountPhoneNum = phoneNum;
                    this.account.BankID = banks[SelectBankCmb.SelectedIndex].BankID;
                    Bounced_Check_Manager_Data_Layer.AccountDAO.update(this.account);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill out all fields");
                }
            }

            private void cancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}
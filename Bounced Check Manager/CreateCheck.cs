using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bounced_Check_Manager
{
    public partial class CreateCheck : Form
    {
        public CreateCheck()
        {
            InitializeComponent();
            //List<Store> stores = StoreDAO.LoadAll();
            //stores.Sort();
            //foreach (var store in stores)
            //{
            //    var c = StoreNumberComboBox;
            //    c.
            //}
        }

        private void AutofillBtn_Click(object sender, EventArgs e)
        {
            if (RoutingNumberTxtBox.Enabled == false)
            {
                // Unlock all of the textboxes
                TextBox[] textBoxes = { FNameTxtBox, LNameTxtBox, AddressTxtBox, RoutingNumberTxtBox, AccNumberTxtBox, BankAddressTxtBox, BankNameTxtBox, PhoneNumberTxtBox };
                foreach (var box in textBoxes)
                {
                    box.Enabled = true;
                }
                AutofillBtn.Text = "Autofill";
                return;
            }
            if (RoutingNumberTxtBox.Text != "")
            {
                if (AccNumberTxtBox.Text != "")
                {
                    // Lookup Account and related bank information and autofill the UI.
                    Account acc = AccountDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text), Convert.ToInt32(AccNumberTxtBox.Text));
                    if (acc != null)
                    {
                        // Autofill values
                        FNameTxtBox.Text = acc.AccountFirstName;
                        LNameTxtBox.Text = acc.AccountLastName;
                        AddressTxtBox.Text = acc.AccountAddress;
                        PhoneNumberTxtBox.Text = acc.AccountPhoneNum.ToString();
                        Bank bank = acc.Bank;
                        BankAddressTxtBox.Text = bank.BankAddress;
                        BankNameTxtBox.Text = bank.BankName;

                        // Lock the text boxes
                        TextBox[] textBoxes = { FNameTxtBox, LNameTxtBox, AddressTxtBox, RoutingNumberTxtBox, AccNumberTxtBox, BankAddressTxtBox, BankNameTxtBox, PhoneNumberTxtBox, };
                        foreach (var box in textBoxes)
                        {
                            box.Enabled = false;
                        }
                        AutofillBtn.Text = "Unlock";
                    }
                    else
                    {
                        MessageBox.Show("No Account found");
                    }
                }
                else
                {
                    // Otherwise just look up the bank information if no account number is provided
                    Bank bank = BankDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text));
                    if (bank != null)
                    {
                        // Autofill values
                        BankAddressTxtBox.Text = bank.BankAddress;
                        BankNameTxtBox.Text = bank.BankName;

                        // Lock the text boxes
                        TextBox[] textBoxes = { RoutingNumberTxtBox, BankAddressTxtBox, BankNameTxtBox };
                        foreach (var box in textBoxes)
                        {
                            box.Enabled = false;
                        }
                        AutofillBtn.Text = "Unlock";
                    }
                    else
                    {
                        MessageBox.Show("No Bank found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please insert routing number or routing number and account number");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Ensure all the data is as desired before proceedings
            if ((RoutingNumberTxtBox.Enabled == false || validateAccount()) && validateCheck() && validateBank())
            {
                // Create bank
                if (BankDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text)) == null)
                {
                    Bank bank = new Bank();
                    bank.BankAddress = BankAddressTxtBox.Text;
                    bank.BankName = BankNameTxtBox.Text;
                    bank.BankRoutingNum = Convert.ToInt32(RoutingNumberTxtBox.Text);
                    if (!BankDAO.create(bank))
                    {
                        MessageBox.Show("Failed to create Bank in database.");
                        return;
                    }
                }

                // Create Account
                if (AccountDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text), Convert.ToInt32(AccNumberTxtBox.Text)) == null)
                {
                    Account acc = new Account();
                    acc.AccountRoutingNum = Convert.ToInt32(RoutingNumberTxtBox.Text);
                    acc.AccountNum = Convert.ToInt32(AccNumberTxtBox.Text);
                    acc.AccountFirstName = FNameTxtBox.Text;
                    acc.AccountLastName = LNameTxtBox.Text;
                    acc.AccountPhoneNum = Convert.ToInt32(PhoneNumberTxtBox.Text);
                    acc.AccountAddress = AddressTxtBox.Text;
                    acc.BankID = BankDAO.find(acc.AccountRoutingNum).BankID;
                    if (!AccountDAO.create(acc))
                    {
                        MessageBox.Show("Failed to create Account in database.");
                        return;
                    }
                }

                // Create Check
                Check check = new Check();
                check.AccountID = AccountDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text), Convert.ToInt32(AccNumberTxtBox.Text)).AccountID;
                check.BankID = BankDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text)).BankID;
                check.StoreID = Convert.ToInt32(StoreNumberComboBox.SelectedValue);
                
                check.CheckDate = CheckDatePicker.Value;
                check.CheckNum = Convert.ToInt32(CheckNumberTxtBox.Text);
                check.CheckAmount = Convert.ToInt32(CheckAmountTxtBox.Text);
                check.CheckAmountOwed = check.CheckAmount;
                check.CheckDeleted = false;
                if (!CheckDAO.create(check))
                {
                    MessageBox.Show("Failed to create Check in database.");
                    return;
                }
                MessageBox.Show("Created check");
                this.Close();
            }

        }

        private bool validateAccount()
        {
            bool ret = true;
            int toss;
            // First Name
            if (FNameTxtBox.Text == "" || FNameTxtBox.Text.Length > 50)
            {
                MessageBox.Show("First name either missing or too long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Last Name
            if (LNameTxtBox.Text == "" || LNameTxtBox.Text.Length > 50)
            {
                MessageBox.Show("Last name either missing or too long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Address
            if (AddressTxtBox.Text == "" || AddressTxtBox.Text.Length > 75)
            {
                MessageBox.Show("Address either missing or too long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Routing Number
            if (RoutingNumberTxtBox.Text == "" || !Int32.TryParse(RoutingNumberTxtBox.Text, out toss))
            {
                MessageBox.Show("Routing Number either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Account Number
            if (AccNumberTxtBox.Text == "" || !Int32.TryParse(AccNumberTxtBox.Text, out toss))
            {
                MessageBox.Show("Account Number either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Phone Number
            // more advanced regex: @"^(?:\(?)(\d{3})(?:[\).]?)(\d{3})(?:[-\.]?)(\d{4})(?!\d)"
            if (PhoneNumberTxtBox.Text == "" || !Regex.Match(PhoneNumberTxtBox.Text, @"^\d{10}").Success)
            {
                MessageBox.Show("Phone Number either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            return ret;
        }

        private bool validateCheck()
        {
            bool ret = true;
            int toss;
            // Check Amount
            if (CheckAmountTxtBox.Text == "" || !Int32.TryParse(CheckAmountTxtBox.Text, out toss))
            {
                MessageBox.Show("Check Amount either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Cashier Number
            if (CashierNumberTxtBox.Text == "" || !Int32.TryParse(CashierNumberTxtBox.Text, out toss))
            {
                MessageBox.Show("Cashier Number either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Check Number
            if (CheckNumberTxtBox.Text == "" || !Int32.TryParse(CheckNumberTxtBox.Text, out toss))
            {
                MessageBox.Show("Check Number either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            return ret;
        }

        private bool validateBank()
        {
            bool ret = true;
            // Bank Name
            if (BankNameTxtBox.Text == "" || BankNameTxtBox.Text.Length > 50)
            {
                MessageBox.Show("Bank Name either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            // Bank Address
            if (BankAddressTxtBox.Text == "" || BankAddressTxtBox.Text.Length > 50)
            {
                MessageBox.Show("Bank Address either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                ret = false;
            }
            return ret;
        }

        private void CreateCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamPenguinDataSet.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.teamPenguinDataSet.Store);

        }
    }
}

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
    namespace Bounced_Check_Manager_UI_Layer
    {
        public partial class CreateCheck : Form
        {
            public CreateCheck()
            {
                InitializeComponent();
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
                    ClearBtn.Enabled = true;
                    return;
                }
                var selecter = new Bounced_Check_Manager_UI_Layer.SelectAccount(AccNumberTxtBox.Text, FNameTxtBox.Text, LNameTxtBox.Text, PhoneNumberTxtBox.Text, AddressTxtBox.Text, RoutingNumberTxtBox.Text);
                selecter.ShowDialog();
                Account acc = selecter.returnAccount;
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
                    RoutingNumberTxtBox.Text = acc.AccountRoutingNum.ToString();
                    AccNumberTxtBox.Text = acc.AccountNum.ToString();

                    // Lock the text boxes
                    TextBox[] textBoxes = { FNameTxtBox, LNameTxtBox, AddressTxtBox, RoutingNumberTxtBox, AccNumberTxtBox, BankAddressTxtBox, BankNameTxtBox, PhoneNumberTxtBox, };
                    foreach (var box in textBoxes)
                    {
                        box.Enabled = false;
                    }
                    AutofillBtn.Text = "Unlock";
                    ClearBtn.Enabled = false;
                }
                return;
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
                    if (Bounced_Check_Manager_Data_Layer.BankDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text)) == null)
                    {
                        Bank bank = new Bank();
                        bank.BankAddress = BankAddressTxtBox.Text;
                        bank.BankName = BankNameTxtBox.Text;
                        bank.BankRoutingNum = Convert.ToInt32(RoutingNumberTxtBox.Text);
                        if (!Bounced_Check_Manager_Data_Layer.BankDAO.create(bank))
                        {
                            MessageBox.Show("Failed to create Bank in database.");
                            return;
                        }
                    }

                    // Create Account
                    if (Bounced_Check_Manager_Data_Layer.AccountDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text), Convert.ToInt32(AccNumberTxtBox.Text)) == null)
                    {
                        Account acc = new Account();
                        acc.AccountRoutingNum = Convert.ToInt32(RoutingNumberTxtBox.Text);
                        acc.AccountNum = Convert.ToInt32(AccNumberTxtBox.Text);
                        acc.AccountFirstName = FNameTxtBox.Text;
                        acc.AccountLastName = LNameTxtBox.Text;
                        acc.AccountPhoneNum = Convert.ToInt32(PhoneNumberTxtBox.Text);
                        acc.AccountAddress = AddressTxtBox.Text;
                        acc.BankID = Bounced_Check_Manager_Data_Layer.BankDAO.find(acc.AccountRoutingNum).BankID;
                        if (!Bounced_Check_Manager_Data_Layer.AccountDAO.create(acc))
                        {
                            MessageBox.Show("Failed to create Account in database.");
                            return;
                        }
                    }

                    // Create Check
                    Check check = new Check();
                    check.AccountID = Bounced_Check_Manager_Data_Layer.AccountDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text), Convert.ToInt32(AccNumberTxtBox.Text)).AccountID;
                    check.BankID = Bounced_Check_Manager_Data_Layer.BankDAO.find(Convert.ToInt32(RoutingNumberTxtBox.Text)).BankID;
                    check.StoreID = Convert.ToInt32(StoreNumberComboBox.SelectedValue);

                    check.CheckDate = CheckDatePicker.Value;
                    check.CheckNum = Convert.ToInt32(CheckNumberTxtBox.Text);
                    check.CheckAmount = Convert.ToDouble(CheckAmountTxtBox.Text);
                    check.CheckAmountOwed = check.CheckAmount;
                    check.CheckDeleted = false;
                    check.CheckCashierID = Convert.ToInt32(CashierNumberTxtBox.Text);
                    if (!Bounced_Check_Manager_Data_Layer.CheckDAO.create(check))
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
                int itoss;
                float ftoss;
                // Check Amount
                if (CheckAmountTxtBox.Text == "" || !float.TryParse(CheckAmountTxtBox.Text, out ftoss))
                {
                    MessageBox.Show("Check Amount either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    ret = false;
                }
                // Cashier Number
                if (CashierNumberTxtBox.Text == "" || !Int32.TryParse(CashierNumberTxtBox.Text, out itoss))
                {
                    MessageBox.Show("Cashier Number either missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    ret = false;
                }
                // Check Number
                if (CheckNumberTxtBox.Text == "" || !Int32.TryParse(CheckNumberTxtBox.Text, out itoss))
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

            private void ClearBtn_Click(object sender, EventArgs e)
            {
                FNameTxtBox.Text = "";
                LNameTxtBox.Text = "";
                AddressTxtBox.Text = "";
                PhoneNumberTxtBox.Text = "";
                BankAddressTxtBox.Text = "";
                BankNameTxtBox.Text = "";
                RoutingNumberTxtBox.Text = "";
                AccNumberTxtBox.Text = "";
            }
        }
    }
}
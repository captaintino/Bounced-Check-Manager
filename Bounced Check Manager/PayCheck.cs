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
        public partial class PayCheck : Form
        {
            List<Check> checks = new List<Check>();

            public PayCheck()
            {
                InitializeComponent();

                if (Globals.isSupervisor)
                {
                    ModifyBtn.Enabled = true;
                }

                // To load all checks when the window comes up:
                // Might consider making this an option
                /*
                List<Account> accounts = Bounced_Check_Manager_Data_Layer.AccountDAO.findAny(AccNumberTxtBox.Text, FNameTxtBox.Text, LNameTextBox.Text, PhoneNumberTxtBox.Text, AddressTxtBox.Text, RoutingNumberTxtBox.Text);
                for (int i = 0; i < accounts.Count; i++)
                {
                    List<Check> checks = Bounced_Check_Manager_Data_Layer.CheckDAO.getChecksFromAcc(accounts[i].AccountID);
                    foreach (Check check in checks)
                    {
                        string[] row = { accounts[i].AccountFirstName + " " + accounts[i].AccountLastName, accounts[i].AccountPhoneNum.ToString(), check.CheckNum.ToString(), check.Bank.BankName, check.Bank.BankAddress, check.CheckDate.ToString(), check.CheckAmount.ToString("C"), check.CheckAmountOwed.ToString("C") };
                        checksGridView.Rows.Add(row);
                    }
                }*/
            }

            private void PayBtn_Click(object sender, EventArgs e)
            {
                if (checksGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select one and only one check");
                    return;
                }
                Check chk = checks[checksGridView.CurrentCell.RowIndex];
                string dialogMsg = "Pay full amount? ($" + chk.CheckAmountOwed.ToString() + ")";
                if (Prompt.ShowCheckDialog(dialogMsg, "Pay"))
                {
                    chk.CheckPaidDate = DateTime.Now;
                    Bounced_Check_Manager_Data_Layer.CheckDAO.update(chk);
                }
            }

            private void PayCheck_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'teamPenguinDataSet.Check' table. You can move, or remove it, as needed.
                this.checkTableAdapter.Fill(this.teamPenguinDataSet.Check);

            }

            private void SearchBtn_Click(object sender, EventArgs e)
            {
                int phone = 0;
                if (PhoneNumberTxtBox.Text != "" && !Int32.TryParse(PhoneNumberTxtBox.Text, out phone))
                {
                    MessageBox.Show("Please enter a valid phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                checksGridView.Rows.Clear();
                checks.Clear();
                List<Account> accounts = Bounced_Check_Manager_Data_Layer.AccountDAO.findAny(AccNumberTxtBox.Text, FNameTxtBox.Text, LNameTextBox.Text, PhoneNumberTxtBox.Text, AddressTxtBox.Text, RoutingNumberTxtBox.Text);
                for (int i = 0; i < accounts.Count; i++)
                {
                    List<Check> newChecks = Bounced_Check_Manager_Data_Layer.CheckDAO.getUnpaidChecksFromAcc(accounts[i].AccountID);
                    checks.AddRange(newChecks);
                }
                for (int i = 0; i < checks.Count; i++)
                {
                    Check check = checks[i];
                    if (check.CheckDeleted && !Globals.isSupervisor)
                    {
                        checks.RemoveAt(i);
                    }
                    else
                    {
                        string[] row = { check.Account.AccountFirstName + " " + check.Account.AccountLastName, check.Account.AccountPhoneNum.ToString(), check.CheckNum.ToString(), check.Bank.BankName, check.Bank.BankAddress, check.CheckDate.ToString(), check.CheckAmount.ToString("C"), check.CheckAmountOwed.ToString("C") };
                        checksGridView.Rows.Add(row);
                        if (check.CheckDeleted)
                        {
                            checksGridView.Rows[i].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
                            checksGridView.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        }
                    }
                }
            }

            private void ModifyBtn_Click(object sender, EventArgs e)
            {
                if (checksGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select one and only one check.");
                    return;
                }
                Check modCheck = checks[checksGridView.CurrentCell.RowIndex];
                if (modCheck != null)
                {
                    new updateCheck(modCheck).Show();
                }
                else
                {
                    MessageBox.Show("There was an error finding the check. Please reselect and try again.");
                    return;
                }
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (checksGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select one and only one check.");
                    return;
                }
                Check delCheck = checks[checksGridView.CurrentCell.RowIndex];
                if (delCheck != null)
                {
                    Bounced_Check_Manager_Data_Layer.CheckDAO.markAsVoid(delCheck);
                    checksGridView.Rows[checksGridView.CurrentCell.RowIndex].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Italic);
                    checksGridView.Rows[checksGridView.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show("There was an error finding the check. Please reselect and try again.");
                    return;
                }
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 150;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
            public static bool ShowCheckDialog(string text, string caption)
            {
                Form prompt = new Form();
                prompt.Width = 270;
                prompt.Height = 150;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;
                Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
                textLabel.AutoSize = true;
                Button confirmation = new Button() { Text = "Yes", Left = 80, Width = 60, Top = 70, DialogResult = DialogResult.OK };
                Button cancellation = new Button() { Text = "No", Left = 10, Width = 60, Top = 70, DialogResult = DialogResult.Cancel };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                cancellation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(cancellation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                prompt.AutoSize = true;
                prompt.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                return prompt.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
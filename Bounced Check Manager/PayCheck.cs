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
    public partial class PayCheck : Form
    {
        public PayCheck()
        {
            InitializeComponent();
            string[] row = {"42", "Fail Bank", "blegh", "10/8/2015", "45.00", "23", "80.00"};
            checksGridView.Rows.Add(row);
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            String prompt = Prompt.ShowDialog("How much to pay?", "0.00");
        }

        private void PayCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamPenguinDataSet.Check' table. You can move, or remove it, as needed.
            this.checkTableAdapter.Fill(this.teamPenguinDataSet.Check);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            checksGridView.Rows.Clear();
            List<Account> accounts = AccountDAO.findAny(AccNumberTxtBox.Text, FNameTxtBox.Text, LNameTextBox.Text, "", AddressTxtBox.Text, RoutingNumberTxtBox.Text);
            for (int i = 0; i < accounts.Count; i++)
            {
                List<Check> checks = CheckDAO.getChecksFromAcc(accounts[i].AccountID);
                foreach (Check check in checks)
                {
                    string[] row = { check.CheckNum.ToString(), check.Bank.BankName, check.Bank.BankAddress, check.CheckDate.ToString(), check.CheckAmount.ToString(), check.CheckCashierID.ToString(), check.CheckAmountOwed.ToString() };
                    checksGridView.Rows.Add(row);
                }
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
    }
}

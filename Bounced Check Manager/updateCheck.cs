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
        public partial class updateCheck : Form
        {
            Check check;
            public updateCheck(Check modCheck)
            {
                InitializeComponent();
                this.check = modCheck;
                AccNameLabel.Text = check.Account.AccountFirstName + " " + check.Account.AccountLastName;
                CheckNumTextBox.Text = check.CheckNum.ToString();
                CheckAmtTextBox.Text = check.CheckAmount.ToString();
                AmtOwedTextBox.Text = check.CheckAmountOwed.ToString();
                CheckWriteDate.Text = check.CheckDate.ToString();
                CheckDatePaid.Text = check.CheckPaidDate.ToString();
            }

            private void submit_Click(object sender, EventArgs e)
            {
                // Consider making these modifiable from this menu?
                // AccountID
                // BankID
                // Store ID
                // Cashier ID
                if (CheckNumTextBox.Text != "" && CheckAmtTextBox.Text != "" && AmtOwedTextBox.Text != "")
                {
                    int checkNum;
                    double checkAmt, amtOwed;
                    try
                    {
                        checkNum = Convert.ToInt32(CheckNumTextBox.Text);
                        checkAmt = Convert.ToDouble(CheckAmtTextBox.Text);
                        amtOwed = Convert.ToDouble(AmtOwedTextBox.Text);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Invalid");
                        return;
                    }
                    check.CheckNum = checkNum;
                    check.CheckAmount = checkAmt;
                    check.CheckAmountOwed = amtOwed;
                    check.CheckDate = CheckWriteDate.Value;
                    check.CheckPaidDate = CheckDatePaid.Value;
                    check.CheckDeleted = false;
                    Bounced_Check_Manager_Data_Layer.CheckDAO.update(check);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill out all fields.");
                }
            }

            private void cancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}

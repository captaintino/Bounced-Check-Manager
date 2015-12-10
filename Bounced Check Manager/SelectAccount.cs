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
        public partial class SelectAccount : Form
        {
            private class AccountItem
            {
                public string name;
                public Account Value;
                public AccountItem(string name, Account value)
                {
                    this.name = name;
                    this.Value = value;
                }
                public override string ToString()
                {
                    return name;
                }
            }
            List<Account> accounts = new List<Account>();
            public Account returnAccount;

            protected override void OnShown(EventArgs e)
            {
                base.OnShown(e);
                if (SelectAccountCmb.Items.Count <= 0)
                {
                    this.Close();
                }
            }

            public SelectAccount(string accNum, string accFirstName, string accLastName, string accPhoneNum, string accAddress, string accRoutNum)
            {
                InitializeComponent();
                accounts = Bounced_Check_Manager_Data_Layer.AccountDAO.findAny(accNum, accFirstName, accLastName, accPhoneNum, accAddress, accRoutNum);
                for (int i = 0; i < accounts.Count; i++)
                {
                    SelectAccountCmb.Items.Add(Bounced_Check_Manager_Data_Layer.AccountDAO.getAccountString(accounts[i]));
                }
                if (SelectAccountCmb.Items.Count > 0)
                {
                    SelectAccountCmb.SelectedIndex = 0;
                }
            }

            private void SelectBtn_Click(object sender, EventArgs e)
            {
                returnAccount = accounts[SelectAccountCmb.SelectedIndex];
                this.Close();
            }

            private void CancelBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}

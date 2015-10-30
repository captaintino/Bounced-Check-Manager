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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ConfirmNewPasswordTxtBox.Text == "" || NewPasswordTxtBox.Text == "" || OldPasswordTxtBox.Text == "")
            {
                MessageBox.Show("Please input a new and old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (ConfirmNewPasswordTxtBox.Text != NewPasswordTxtBox.Text)
            {
                MessageBox.Show("New passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            User user = Bounced_Check_Manager_Data_Layer.UserDAO.find(Globals.username);
            bool success = Bounced_Check_Manager_Data_Layer.UserDAO.changePasswordUser(user, OldPasswordTxtBox.Text, ConfirmNewPasswordTxtBox.Text);
            if (success)
            {
                MessageBox.Show("Password successfully changed!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not change password (invalid old password?)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }
}

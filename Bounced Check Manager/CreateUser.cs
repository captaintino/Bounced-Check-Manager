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
        public partial class CreateUser : Form
        {
            public CreateUser()
            {
                InitializeComponent();
                RoleComboBox.SelectedIndex = 0;
            }

            private void CancelBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void SubmitBtn_Click(object sender, EventArgs e)
            {
                if (UsernameTxtBox.Text != "" && PasswordTxtBox.Text != "")
                {
                    if (!Bounced_Check_Manager_Data_Layer.UserDAO.validatePassword(PasswordTxtBox.Text))
                    {
                        MessageBox.Show("Password too simple.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    bool success = Bounced_Check_Manager_Data_Layer.UserDAO.create(UsernameTxtBox.Text, PasswordTxtBox.Text);
                    if (success)
                    {
                        MessageBox.Show("User Created");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create user in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Please input a valid username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
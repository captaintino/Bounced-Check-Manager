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
        public partial class ModifyUsers : Form
        {
            List<User> users;
            public ModifyUsers()
            {
                InitializeComponent();
                UpdateList();
            }

            public void UpdateList()
            {
                users = Bounced_Check_Manager_Data_Layer.UserDAO.listAll();
                UsersDataGridView.Rows.Clear();
                foreach (User user in users)
                {
                    string[] row = { user.sid.ToString(), user.status.ToString(), user.name, user.createdate.ToShortDateString(), user.updatedate.ToShortDateString(), user.accdate.ToShortDateString() };
                    UsersDataGridView.Rows.Add(row);
                }
            }

            private void DeleteBtn_Click(object sender, EventArgs e)
            {
                if (UsersDataGridView.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select a singe login to delete");
                    return;
                }
                int index = UsersDataGridView.SelectedRows[0].Index;
                User user = users[index];
                if (MessageBox.Show("Are you sure you want to delete " + user.name + "?", "Delete " + user.name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) != DialogResult.Yes)
                {
                    return;
                }
                if (user.name == Globals.username)
                {
                    MessageBox.Show("You're not allowed to delete yourself!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                bool success = Bounced_Check_Manager_Data_Layer.UserDAO.delete(user);
                if (success)
                {
                    MessageBox.Show("Deleted " + user.name);
                    UpdateList();
                }
            }
        }
    }
}
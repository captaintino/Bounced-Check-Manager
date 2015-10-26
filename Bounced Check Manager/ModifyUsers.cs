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
    public partial class ModifyUsers : Form
    {
        List<User> users;
        public ModifyUsers()
        {
            InitializeComponent();
            users = UserDAO.listAll();
            UsersDataGridView.Rows.Clear();
            foreach (User user in users){
                string[] row = { user.uid.ToString(), user.status.ToString(), user.name, user.roles, user.createdate.ToShortDateString(), user.updatedate.ToShortDateString(), user.altuid.ToString(), user.gid.ToString() };
                UsersDataGridView.Rows.Add(row);
            }
        }
    }
}

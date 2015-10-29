﻿using System;
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
        public partial class login : Form
        {
            public bool loggedIn = false;
            public login()
            {
                InitializeComponent();
            }

            private void loginBtn_Click(object sender, EventArgs e)
            {
                String connectionString = "Data Source=CPSLABSERVER\\TEAMPENGUIN;Initial Catalog=TeamPenguin;Persist Security Info=True;User ID=" + username.Text + ";Password=" + password.Text;
                DataClasses1DataContext database = new DataClasses1DataContext(connectionString);
                if (!database.DatabaseExists())
                {
                    MessageBox.Show("Unable to reach database. Invalid Login/Password", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Globals.connectionString = connectionString;
                Globals.username = username.Text;
                this.loggedIn = true;
                this.Close();
            }

            private void cancelBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}
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
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }

        private void ModifyUsersBtn_Click(object sender, EventArgs e)
        {
            new ModifyUsers().Show();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            new CreateUser().Show();
        }
    }
}

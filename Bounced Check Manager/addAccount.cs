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
    public partial class addAccount : Form
    {
        private int accountID;

        public addAccount(int id)
        {
            accountID = id;

            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && addressTextBox.Text != "" && routingNumberTextBox.Text != "" && accountNumberTextBox.Text != "")
            {
                int routing = 0;
                int account = 0;
                try
                {
                    routing = Convert.ToInt32(routingNumberTextBox.Text);
                    account = Convert.ToInt32(accountNumberTextBox.Text);
                }catch(Exception ex){
                    MessageBox.Show("Invalid account or routing number");
                    return;
                }
                
                Account acc = new Account(accountID, nameTextBox.Text, addressTextBox.Text, routing, account);
                AccountDAO.create(acc);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }
        }
    }
}

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
    public partial class ModifyBank : Form
    {
        Bank bank;
        public ModifyBank(Bank new_bank)
        {
            InitializeComponent();
            bank = new_bank;
            RoutingNumTxtBox.Text = bank.BankRoutingNum.ToString();
            BankNameTxtBox.Text = bank.BankName.ToString();
            BankAddressTxtBox.Text = bank.BankAddress.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int routingNum;
            // Perform validity checks on bank data
            if (!ManageBank.validateBank(BankNameTxtBox.Text, BankAddressTxtBox.Text))
            {
                return;
            }
            if (!Int32.TryParse(RoutingNumTxtBox.Text, out routingNum))
            {
                MessageBox.Show("Please give a valid routing number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (Bounced_Check_Manager_Data_Layer.BankDAO.find(routingNum) != null && Bounced_Check_Manager_Data_Layer.BankDAO.find(routingNum).BankID != bank.BankID)
            {
                MessageBox.Show("Bank with routing number " + routingNum.ToString() + " already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            // Generate bank
            bank.BankRoutingNum = routingNum;
            bank.BankName = BankNameTxtBox.Text;
            bank.BankAddress = BankAddressTxtBox.Text;
            // Submit store
            if (Bounced_Check_Manager_Data_Layer.BankDAO.update(bank))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Bank Creation failed at database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

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
    public partial class ManageBank : Form
    {
        List<Bank> banks;
        public ManageBank()
        {
            InitializeComponent();
            banks = Bounced_Check_Manager_Data_Layer.BankDAO.LoadAll();
        }

        private void ManageBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamPenguinDataSet.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.teamPenguinDataSet.Bank);
        }

        public static bool validateBank(String bankName, String bankAddress)
        {
            if (bankName.Length == 0)
            {
                MessageBox.Show("Please Provide a Bank Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            } if (bankName.Length > 50)
            {
                MessageBox.Show("Please Give a Bank Name Shorter than 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (bankAddress.Length == 0)
            {
                MessageBox.Show("Please Provide a Bank Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            } if (bankAddress.Length > 50)
            {
                MessageBox.Show("Please Give a Bank Address Shorter than 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            banks = Bounced_Check_Manager_Data_Layer.BankDAO.LoadAll();
            this.ManageBank_Load(null, null);
        }

        private void ModifyBankBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select one and only one store");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new ModifyBank(banks[row.Index]).Show();
            }
        }
    }
}

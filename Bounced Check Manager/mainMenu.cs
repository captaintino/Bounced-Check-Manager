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
    public partial class mainMenu : Form
    {
        List<Account> accounts = new List<Account>();
        public mainMenu()
        {
            InitializeComponent();
            // Might be a better way to do this. Basically the table should start out refreshed, without
            // the user clicking on anything.
            refreshBtn_Click(null, null);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            accounts = AccountDAO.LoadAll();
            dataGridView1.Rows.Clear();
            foreach (Account acc in accounts){
                string[] row = { acc.AccID.ToString(), acc.AccName.ToString(), acc.AccAddress.ToString(), acc.AccRoutNo.ToString(), acc.AccNo.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // The count comes from the current list, NOT the one in the DB! This will NOT work for
            // a network DB serving multiple programs!
            new addAccount(accounts.Count).Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select an account");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Account acc = findAccount(id);
                AccountDAO.delete(acc);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select one and only one account");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Account acc = findAccount(id);
                new updateAccount(acc).Show();
            }
        }

        public Account findAccount(int id)
        {
            foreach (Account acc in accounts)
            {
                if (acc.AccID == id)
                {
                    return acc;
                }
            }
            return null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCheckBtn_Click(object sender, EventArgs e)
        {
            new CreateCheck().Show();
        }

        private void PayCheckBtn_Click(object sender, EventArgs e)
        {
            new PayCheck().Show();
        }

        private void GenerateLettersBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your letters are printing...");
        }

        
    }
}

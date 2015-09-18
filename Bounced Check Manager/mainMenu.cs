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
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            accounts = AccountDAO.LoadAll();
            dataGridView1.Rows.Clear();
            foreach (Account acc in accounts){
                string[] row = { acc.id.ToString(), acc.name.ToString(), acc.address.ToString(), acc.routingNumber.ToString(), acc.accountNumber.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new addAccount().Show();
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
                MessageBox.Show("Please Select an account");
                return;
            }
            Account acc = findAccount(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0]));
            new updateAccount(acc).Show();
        }

        public Account findAccount(int id)
        {
            foreach (Account acc in accounts)
            {
                if (acc.id == id)
                {
                    return acc;
                }
            }
            return null;
        }

        
    }
}

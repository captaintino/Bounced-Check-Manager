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
    public partial class ManageStore : Form
    {
        List<Store> stores;
        public ManageStore()
        {
            InitializeComponent();
            stores = Bounced_Check_Manager_Data_Layer.StoreDAO.LoadAll();
        }

        private void ManageStore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamPenguinDataSet.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.teamPenguinDataSet.Store);

        }

        public static bool ValidateStore(String storeName, String storeAddress, String storeFee)
        {
            double checkFee;
            // Perform validity checks on store data
            if (storeName.Length == 0)
            {
                MessageBox.Show("Please Provide a Store Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            } if (storeName.Length > 50)
            {
                MessageBox.Show("Please Give a Store Name Shorter than 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            } if (storeAddress.Length == 0)
            {
                MessageBox.Show("Please Provide a Store Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            } if (storeAddress.Length > 75)
            {
                MessageBox.Show("Please Give a Store Address Shorter than 75 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            } if (!double.TryParse(storeFee, out checkFee))
            {
                MessageBox.Show("Store Bounced Check Fee Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void CreateStoreBtn_Click(object sender, EventArgs e)
        {
            new CreateStore().Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            stores = Bounced_Check_Manager_Data_Layer.StoreDAO.LoadAll();
            this.ManageStore_Load(null, null);
        }

        private void ModifyStoreBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select one and only one store");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new ModifyStore(stores[row.Index]).Show();
            }
        }
    }
}

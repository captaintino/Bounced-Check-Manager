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
    public partial class ModifyStore : Form
    {
        Store store;
        public ModifyStore(Store modify_store)
        {
            InitializeComponent();
            this.store = modify_store;
            StoreNumTxtBox.Text = store.StoreNum.ToString();
            StoreNameTxtBox.Text = store.StoreName.ToString();
            StoreAddressTxtBox.Text = store.StoreAddress.ToString();
            StoreCheckFeeTxtBox.Text = store.StoreServiceCharge.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int storeNum;
            double checkFee;
            // Perform validity checks on store data
            if (!ManageStore.ValidateStore(StoreNameTxtBox.Text, StoreAddressTxtBox.Text, StoreCheckFeeTxtBox.Text))
            {
                return;
            }
            if (!Int32.TryParse(StoreNumTxtBox.Text, out storeNum))
            {
                MessageBox.Show("Store Number invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            } if (Bounced_Check_Manager_Data_Layer.StoreDAO.find(storeNum) != null && Bounced_Check_Manager_Data_Layer.StoreDAO.find(storeNum).StoreID != store.StoreID)
            {
                MessageBox.Show("Store " + storeNum.ToString() + " Already Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            } 
            double.TryParse(StoreCheckFeeTxtBox.Text, out checkFee);
            // Generate store
            store.StoreNum = storeNum;
            store.StoreName = StoreNameTxtBox.Text;
            store.StoreAddress = StoreAddressTxtBox.Text;
            store.StoreServiceCharge = Convert.ToDecimal(checkFee);
            // Submit store
            if (Bounced_Check_Manager_Data_Layer.StoreDAO.update(store))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Store Update failed at database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

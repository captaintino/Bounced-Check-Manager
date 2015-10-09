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
    public partial class CreateCheck : Form
    {
        public CreateCheck()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RoutingNumberTxtBox.Text != "" && AccNumberTxtBox.Text != "")
            {
                FNameTxtBox.Text = "Austin";
                LNameTextBox.Text = "Carroll";
                AddressTxtBox.Text = "1234 A+ Lane\r\nAwesomeness SC 01337";
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created check");
            this.Close();
        }
    }
}

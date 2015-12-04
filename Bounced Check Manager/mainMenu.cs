using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Bounced_Check_Manager
{
    namespace Bounced_Check_Manager_UI_Layer
    {
        public partial class mainMenu : Form
        {
            List<Tuple<Letter, String>> lettersTupleList = new List<Tuple<Letter, String>>();
            List<Tuple<Letter, String>>.Enumerator letterEnumerator = new List<Tuple<Letter, String>>.Enumerator();
            List<Account> accounts = new List<Account>();
            public mainMenu()
            {
                InitializeComponent();
                if (!Globals.isSupervisor)
                {
                    supervisorToolStripMenuItem.Enabled = false;
                }
                accounts = Bounced_Check_Manager_Data_Layer.AccountDAO.LoadAll();
            }

            private void refreshBtn_Click(object sender, EventArgs e)
            {
                accounts = Bounced_Check_Manager_Data_Layer.AccountDAO.LoadAll();
                //dataGridView1.Rows.Clear();
                //foreach (Account acc in accounts){
                //    string[] row = { acc.AccID.ToString(), acc.AccName.ToString(), acc.AccAddress.ToString(), acc.AccRoutNo.ToString(), acc.AccNo.ToString() };
                //    dataGridView1.Rows.Add(row);
                //}
                Bounced_Check_Manager_Data_Layer.UnitTest.run();
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
                    Bounced_Check_Manager_Data_Layer.AccountDAO.delete(acc);
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
                    if (acc != null)
                    {
                        new updateAccount(acc).Show();
                    }
                    else
                    {
                        MessageBox.Show("There was an error locating the account");
                        return;
                    }
                }
            }

            public Account findAccount(int id)
            {
                foreach (Account acc in accounts)
                {
                    if (acc.AccountID == id)
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
                PrintDocument document = new PrintDocument();
                document.PrintPage += document_PrintPage;
                document.BeginPrint += document_BeginPrint;
                lettersTupleList = Bounced_Check_Manager_Data_Layer.LetterDAO.generateLetters();

                if (lettersTupleList.Count == 0)
                {
                    MessageBox.Show("No letters to print.");
                    return;
                }

                // Choose printer 
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.Document = document;
                DialogResult result = printDialog1.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                // Print the monster!
                document.Print();
                foreach (var tuple in lettersTupleList)
                {
                    Bounced_Check_Manager_Data_Layer.LetterDAO.create(tuple.Item1);
                }
                MessageBox.Show("Your letters are printing...");
            }

            void document_BeginPrint(object sender, PrintEventArgs e)
            {
                // Set enumerator
                letterEnumerator = lettersTupleList.GetEnumerator();
                //position to first string to print (i.e. first page)
                letterEnumerator.MoveNext();
            }

            void document_PrintPage(object sender, PrintPageEventArgs e)
            {
                Font sFont = new Font("Arial", 12);
                Brush sBrush = Brushes.Black;

                //print current page
                e.Graphics.DrawString(letterEnumerator.Current.Item2, sFont, sBrush, e.MarginBounds, StringFormat.GenericTypographic);

                // advance enumerator to determine if we have more pages.
                e.HasMorePages = letterEnumerator.MoveNext();
            }

            private void mainMenu_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'teamPenguinDataSet.Account' table. You can move, or remove it, as needed.
                this.accountTableAdapter.Fill(this.teamPenguinDataSet.Account);
            }

            private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
            {
                new Supervisor().Show();
            }

            private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
            {
                new ChangePassword().Show();
            }


        }
    }
}
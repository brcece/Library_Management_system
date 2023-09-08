using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hrbid_Library
{
    public partial class DashboardM : Form
    {
        public DashboardM()
        {
            InitializeComponent();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook dash = new AddBook();
            dash.Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search dash = new Search();
            dash.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBook dash = new EditBook();
            dash.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO EXIT ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                manager dash = new manager();
                dash.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void editMyProflieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstock dash = new addstock();
            dash.Show();
        }

        private void studentsAndLibrariansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersstudent dash = new usersstudent();
            dash.Show();
        }

        private void myAcountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myacountmanager dash = new myacountmanager();
            dash.Owner = this;
            dash.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            history dash = new history();
            dash.Owner = this;
            dash.Show();
        }

        private void dashborad_menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

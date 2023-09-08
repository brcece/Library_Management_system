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
    public partial class DashboradL : Form
    {
        public DashboradL()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstudent dash = new addstudent();
            dash.Show();
        }

        private void eDİTBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search dash = new Search();
            dash.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO EXIT ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                LIBRARIAN dash = new LIBRARIAN();
                dash.Show();
                this.Close();
            }
            
        }

        private void borrowABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow_Books dash = new Borrow_Books();
            dash.Show();
            
        }

        private void extendTheBorrowingPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extend_time_lıbrarıan dash = new Extend_time_lıbrarıan();
            dash.Show();
            
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook dash = new ReturnBook();
            dash.Show();
            
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DashboradL_Load(object sender, EventArgs e)
        {

        }

        private void dashborad_menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history dash = new history();
            dash.Owner = this;
            dash.Show();
        }

        private void overdueReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            send_mail dash = new send_mail();
            dash.Owner = this;
            dash.Show();
        }
    }
}

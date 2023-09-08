using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hrbid_Library
{
    public partial class Dashboard : Form

    {
        private SqlConnection baglantı;
        public string userName;
        public Dashboard()
        {
            InitializeComponent();

            baglantı = new SqlConnection(
                "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
            baglantı.Open();
        }

        private void extendTheBorrowingPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrow_time dash = new borrow_time();
            dash.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO EXIT ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                
            }
            Form1 dash = new Form1();
            dash.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void borrowABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrow_Books dash = new Borrow_Books();
            dash.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myBorrowListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyBorrowList dash = new MyBorrowList();
            dash.Show();
        }

        private void myReadingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyreadingList dash = new MyreadingList();
            dash.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook sngup = new ReturnBook();
            sngup.Show();
        }

        private void editMyProflieToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Editmyprofile sngup = new Editmyprofile();
            sngup.Show();
            
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrow_time dash = new borrow_time();
            dash.Show();
        }
    }
}

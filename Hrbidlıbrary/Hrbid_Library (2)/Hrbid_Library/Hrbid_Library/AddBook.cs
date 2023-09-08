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
    public partial class AddBook : Form
    {
        private int stock { get; set; }
        private string bookname { get; set; }
        public AddBook()
        {
            InitializeComponent();
        }

        private SqlConnection kitap =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void add_button_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel?", "WILL NOT BE SAVED", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
            DashboardM dash = new DashboardM();
            dash.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add_textBox_booksname.Text == "Book's Name" || add_textBox_author.Text == "Author" || add_textBox_type.Text == "Type" || add_textBox_pages.Text == "Number Of Pages" || add_textBox_firstedition.Text == "First Edition Time" ||
                add_textBox_booksname.Text == "<3 <3 <3" || add_textBox_author.Text == "<3 <3 <3" || add_textBox_type.Text == "<3 <3 <3" || add_textBox_pages.Text == "<3 <3 <3" || add_textBox_firstedition.Text == "<3 <3 <3" ||
                String.IsNullOrWhiteSpace(add_textBox_booksname.Text) || String.IsNullOrWhiteSpace(add_textBox_type.Text) || String.IsNullOrWhiteSpace(add_textBox_pages.Text) || String.IsNullOrWhiteSpace(add_textBox_firstedition.Text) || String.IsNullOrWhiteSpace(add_textBox_author.Text))
            {
                MessageBox.Show("You Can't Save Like This !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                kitap.Open();
                SqlCommand komut =
                    new SqlCommand(
                        "insert into BooksList(book_name,author,type,number_of_pages,time,stock)values(@book_name,@author,@type,@number_of_pages,@time,@stock)",
                        kitap);
                komut.Parameters.AddWithValue(("@book_name"), add_textBox_booksname.Text);
                komut.Parameters.AddWithValue(("@author"), add_textBox_author.Text);
                komut.Parameters.AddWithValue(("@type"), add_textBox_type.Text);
                komut.Parameters.AddWithValue(("@number_of_pages"), add_textBox_pages.Text);
                komut.Parameters.AddWithValue(("@time"), add_textBox_firstedition.Text);
                komut.Parameters.AddWithValue(("@stock"),textBox1.Text);
                komut.ExecuteNonQuery();
                kitap.Close();

                MessageBox.Show("Added");
                foreach (Control item in Controls)

                {
                    if (item is TextBox)
                    {
                        item.Text = "<3 <3 <3";

                    }

                }

                



            }
        }

        private void add_textBox_booksname_TextChanged(object sender, EventArgs e)
        {
            if (add_textBox_booksname.Text == "Book's Name")
            {
                add_textBox_booksname.Clear();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void add_textBox_author_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_textBox_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_textBox_pages_TextChanged(object sender, EventArgs e)
        {


        }

        private void add_textBox_firstedition_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_textBox_booksname_MouseEnter(object sender, EventArgs e)
        {

        }

        private void add_textBox_booksname_MouseClick(object sender, MouseEventArgs e)
        {
            if (add_textBox_booksname.Text == "Book's Name" || add_textBox_booksname.Text == "<3 <3 <3")
            {
                add_textBox_booksname.Clear();

            }
        }

        private void add_textBox_author_MouseEnter(object sender, EventArgs e)
        {

        }

        private void add_textBox_author_MouseClick(object sender, MouseEventArgs e)
        {
            if (add_textBox_author.Text == "Author" || add_textBox_author.Text == "<3 <3 <3")
            {
                add_textBox_author.Clear();

            }
        }

        private void add_textBox_type_MouseEnter(object sender, EventArgs e)
        {

        }

        private void add_textBox_type_MouseClick(object sender, MouseEventArgs e)
        {
            if (add_textBox_type.Text == "Type" || add_textBox_type.Text == "<3 <3 <3")
            {
                add_textBox_type.Clear();
            }
        }

        private void add_textBox_pages_MouseEnter(object sender, EventArgs e)
        {

        }

        private void add_textBox_pages_MouseClick(object sender, MouseEventArgs e)
        {
            if (add_textBox_pages.Text == "Number Of Pages" || add_textBox_pages.Text == "<3 <3 <3")
            {
                add_textBox_pages.Clear();
            }
        }

        private void add_textBox_firstedition_MouseEnter(object sender, EventArgs e)
        {

        }

        private void add_textBox_firstedition_MouseClick(object sender, MouseEventArgs e)
        {
            if (add_textBox_firstedition.Text == "First Edition Time" || add_textBox_firstedition.Text == "<3 <3 <3")
            {
                add_textBox_firstedition.Clear();
            }
        }

        private void add_button_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?", "WILL NOT BE SAVED", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_textBox_booksname.Text = "";
            add_textBox_author.Text = "";
            add_textBox_type.Text = "";
            add_textBox_pages.Text = "";
            add_textBox_firstedition.Text = "";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Number Of Books" || textBox1.Text == "<3 <3 <3")
            {
                textBox1.Clear();
            }
        }
    }
}

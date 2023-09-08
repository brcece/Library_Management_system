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
    public partial class ADDBOOKMYLIST : Form
    {
        public ADDBOOKMYLIST()
        {
            InitializeComponent();
        }

        private bool read;

        private SqlConnection kitap =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void add_textBox_type_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void add_button_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel?", "WILL NOT BE SAVED", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
            MyreadingList dash = new MyreadingList();
            dash.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (add_textBox_booksname.Text == "Book's Name" || add_textBox_author.Text == "Author" ||
                add_textBox_type.Text == "Type" || add_textBox_pages.Text == "Number Of Pages" ||
                add_textBox_firstedition.Text == "First Edition Time" ||
                add_textBox_booksname.Text == "<3 <3 <3" || add_textBox_author.Text == "<3 <3 <3" ||
                add_textBox_type.Text == "<3 <3 <3" || add_textBox_pages.Text == "<3 <3 <3" ||
                add_textBox_firstedition.Text == "<3 <3 <3" ||
                String.IsNullOrWhiteSpace(add_textBox_booksname.Text) ||
                String.IsNullOrWhiteSpace(add_textBox_type.Text) || String.IsNullOrWhiteSpace(add_textBox_pages.Text) ||
                String.IsNullOrWhiteSpace(add_textBox_firstedition.Text) ||
                String.IsNullOrWhiteSpace(add_textBox_author.Text))
            {
                MessageBox.Show("You Can't Save Like This !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                kitap.Open();
                SqlCommand komut =
                    new SqlCommand("insert into Read_List (userid,bookid,Book_Name,Author,Book_Type,Number_of_Pages,Timee,Read_or_Not_Read) values (@userid,@bookid,@Book_Name,@Author,@Book_Type,@Number_of_Pages,@Timee,@Read_or_Not_Read)", kitap);
                komut.Parameters.AddWithValue(("@userid"), Program.CurrrentUserID.ToString());
                komut.Parameters.AddWithValue(("@bookid"), 0);
                komut.Parameters.AddWithValue(("@Book_Name"), add_textBox_booksname.Text);
                komut.Parameters.AddWithValue(("@Author"), add_textBox_author.Text);
                komut.Parameters.AddWithValue(("@Book_Type"), add_textBox_type.Text);
                komut.Parameters.AddWithValue(("@Number_of_Pages"), int.Parse(add_textBox_pages.Text));
                komut.Parameters.AddWithValue(("@Timee"), add_textBox_firstedition.Text);
                komut.Parameters.AddWithValue(("@Read_or_Not_Read"), read); 
                
                komut.ExecuteNonQuery();
                kitap.Close();

                MessageBox.Show("Added","Complated", MessageBoxButtons.OK);
                foreach (Control item in Controls)

                {
                    



                }
            }
        }

        private void add_textBox_booksname_TextChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADDBOOKMYLIST_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            read = radioButton1.Checked;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_textBox_pages_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            read = !radioButton2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_textBox_booksname.Text = "";
            add_textBox_author.Text = "";
            add_textBox_type.Text = "";
            add_textBox_pages.Text = "";
            add_textBox_firstedition.Text = "";


        }
    }

        
}

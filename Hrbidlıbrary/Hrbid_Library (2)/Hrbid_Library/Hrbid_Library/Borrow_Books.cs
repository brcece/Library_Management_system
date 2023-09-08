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
using System.Net;

namespace Hrbid_Library
{
    public partial class Borrow_Books : Form
    {
        public Borrow_Books()
        {
            InitializeComponent();

        }

        private int stock { get; set; }
        private int BookID { get; set; }
        private string BookName { get; set; }
        private string Author { get; set; }
        private string fullname { get; set; }

        private string bookname { get; set; }

        private int result  {get; set; }
        private string Ttype { get; set; }
        private int Numberofpages { get; set; }
        private string Timee { get; set; }
        
        private int studentID { get; set; }

        private bool read;

        private bool isitreturn;

        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borrow_button_borrow_Click(object sender, EventArgs e)
        {
            if (BookName == null)
            {

                MessageBox.Show("You Did Not Choose", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                SqlCommand komut =
                    new SqlCommand(
                        "insert into Borrow_List (booknameid,bookname,userid,studentname,studentID,startedtime,endingtime) values (@booknameid,@bookname, @userid,@studentname,@studentID,@startedtime,@endingtime)",
                        con);
                komut.Parameters.AddWithValue(("@booknameid"), BookID);
                komut.Parameters.AddWithValue(("@bookname"), BookName);
                komut.Parameters.AddWithValue(("@userid"), result);
                komut.Parameters.AddWithValue(("@studentname"), fullname);
                komut.Parameters.AddWithValue(("@studentID"), studentID);
                komut.Parameters.AddWithValue(("@startedtime"), dateTimePicker1.Text);
                komut.Parameters.AddWithValue(("@endingtime"), dateTimePicker2.Text);
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(BookName, "Your Book is", MessageBoxButtons.OK);
                
                
                con.Open();
                SqlCommand fr=
                    new SqlCommand(
                    "insert into Read_List (userid,bookid,Book_Name,Author,Book_Type,Number_of_Pages,Timee,Read_or_Not_Read) values (@userid,@bookid,@Book_Name,@Author,@Book_Type,@Number_of_Pages,@Timee,@Read_or_Not_Read)",
                    con);
                fr.Parameters.AddWithValue(("@userid"),result);
                fr.Parameters.AddWithValue(("@bookid"), BookID);
                fr.Parameters.AddWithValue(("@Book_Name"), BookName);
                fr.Parameters.AddWithValue(("@Author"), Author);
                fr.Parameters.AddWithValue(("@Book_Type"), Ttype);
                fr.Parameters.AddWithValue(("@Number_of_Pages"), Numberofpages);
                fr.Parameters.AddWithValue(("@Timee"), Timee);
                fr.Parameters.AddWithValue(("@Read_or_Not_Read"), read=true);
                fr.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand ls =
                    new SqlCommand(
                        "insert into Borrow__history (booknameid,bookname,userid,studentname,studentID,startedtime,endingtime,isitreturn) values (@booknameid,@bookname, @userid,@studentname,@studentID,@startedtime,@endingtime,@isitreturn)",
                        con);
                ls.Parameters.AddWithValue(("@booknameid"), BookID);
                ls.Parameters.AddWithValue(("@bookname"), BookName);
                ls.Parameters.AddWithValue(("@userid"), result);
                ls.Parameters.AddWithValue(("@studentname"), fullname);
                ls.Parameters.AddWithValue(("@studentID"), studentID);
                ls.Parameters.AddWithValue(("@startedtime"), dateTimePicker1.Text);
                ls.Parameters.AddWithValue(("@endingtime"), dateTimePicker2.Text);
                ls.Parameters.AddWithValue(("@isitreturn"),isitreturn=false);
                ls.ExecuteNonQuery();
                con.Close();
                


                con.Open();
                SqlCommand cd =
                    new SqlCommand("UPDATE BooksList SET stock = " + stock + " WHERE book_name= '" + bookname +"'", con);
                cd.ExecuteNonQuery();
                con.Close();
                borrow_textBox.Text = "";
                studentID_textBox2.Text = "";
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();


            }
        }

        private void Borrow_Books_Load(object sender, EventArgs e)
        {
            //Program.CurrentUserID;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BooksList ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            stock = (int)ds.Tables[0].Rows[0]["stock"];
            stock = stock - 1;
            bookname = ds.Tables[0].Rows[0]["book_name"].ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void borrow_button_check_Click(object sender, EventArgs e)
        {
            



        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataTable dt = dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                BookID = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
                BookName = dt.Rows[e.RowIndex][1].ToString();
                Author = dt.Rows[e.RowIndex][2].ToString();
                Ttype = dt.Rows[e.RowIndex][3].ToString();
                Numberofpages= Int32.Parse(dt.Rows[e.RowIndex][4].ToString());
                Timee = dt.Rows[e.RowIndex][5].ToString();
                
               
            }

        }

        private void borrow_button_anotherbook_Click(object sender, EventArgs e)
        {


            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrow_textBox_TextChanged(object sender, EventArgs e)
        {
            if (borrow_textBox.Text != "")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BooksList where book_name LIKE '" + borrow_textBox.Text + "%' or author LIKE'" + borrow_textBox.Text + "%' or type LIKE '"+ borrow_textBox.Text + " % '";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                stock = (int)ds.Tables[0].Rows[0]["stock"];
                stock = stock - 1;
                bookname = ds.Tables[0].Rows[0]["book_name"].ToString();

            }
        }

        private void borrow_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CHECKSTUDENTbutton2_Click(object sender, EventArgs e)
        {
            if (studentID_textBox2.Text != "")
            {
                try

                {
                    try
                    {


                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "select * from userTable where  studentID LIKE '" +
                                          int.Parse(studentID_textBox2.Text) +
                                          "%' and roleid = 2 ";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        result = (int)ds.Tables[0].Rows[0]["id"];
                        fullname = ds.Tables[0].Rows[0]["fullname"].ToString();
                        studentID = (int)ds.Tables[0].Rows[0]["studentID"];


                        MessageBox.Show(fullname, "Student Name", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "select * from userTable where (fullname LIKE '" + studentID_textBox2.Text +
                                          "%' or username LIKE '" + studentID_textBox2.Text + "%' ) and roleid = 2 ";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        result = (int)ds.Tables[0].Rows[0]["id"];
                        fullname = ds.Tables[0].Rows[0]["fullname"].ToString();
                        studentID= (int)ds.Tables[0].Rows[0]["studentID"];

                        MessageBox.Show(fullname, "Student Name", MessageBoxButtons.OK);
                    }

                }

                catch
                {
                    MessageBox.Show("Student Not Found", "NOT FOUND", MessageBoxButtons.OK);
                }
            }
        }

        private void studentID_textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

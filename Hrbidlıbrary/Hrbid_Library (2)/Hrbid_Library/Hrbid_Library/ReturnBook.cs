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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
        private int stock { get; set; }
        private bool isreturn;
        private int Booknameıd { get; set; }
        private string Author { get; set; }
        private string fullname { get; set; }

        private string bookname { get; set; }

        private int result { get; set; }
        private int BookID { get; set; }
        private string BookName { get; set; }
        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void borrow_button_check_Click(object sender, EventArgs e)
        {

        }

        private void borrow_button_anotherbook_Click(object sender, EventArgs e)
        {
            borrow_textBox.Text = "";
            studentID_textBox2.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrow_Books dash = new Borrow_Books();
            dash.Show();
            this.Hide();
        }

        private void return_button_borrow_Click(object sender, EventArgs e)
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
                        "DELETE FROM Borrow_List WHERE booknameid=@booknameid AND bookname=@bookname AND userid=@userid",
                        con);
                komut.Parameters.AddWithValue(("@booknameid"), BookID);
                komut.Parameters.AddWithValue(("@bookname"), BookName);
                komut.Parameters.AddWithValue(("@userid"), result);
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(BookName, "Deleted", MessageBoxButtons.OK);



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BooksList where book_name LIKE '" + BookName + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                stock = (int)ds.Tables[0].Rows[0]["stock"];
                stock = stock + 1;
                bookname = ds.Tables[0].Rows[0]["book_name"].ToString();


                cmd.CommandText = "select * from Borrow__history where bookname LIKE '" + BookName + "'";
                SqlDataAdapter di = new SqlDataAdapter(cmd);
                DataSet dk = new DataSet();
                di.Fill(dk);


                
                isreturn = true;

                con.Open();
                SqlCommand cd =
                    new SqlCommand("UPDATE BooksList SET stock = " + stock + " WHERE book_name= '" + BookName + "'", con);
                cd.ExecuteNonQuery();
                con.Close();

                con.Open();

                SqlCommand ls = new SqlCommand("UPDATE Borrow__history SET isitreturn = '" + isreturn + "' WHERE bookname = '" + BookName+"'", con);

                ls.ExecuteNonQuery();
                con.Close();
            }
            SqlCommand afk = new SqlCommand();
            afk.Connection = con;
            ;

            afk.CommandText = "select * from Borrow_List where userid =" + result;
            SqlDataAdapter af = new SqlDataAdapter(afk);
            DataSet dl = new DataSet();
            af.Fill(dl);
            dataGridView1.DataSource = dl.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns["booknameid"].Visible = false;
            dataGridView1.Columns["userid"].Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                BookID = Int32.Parse(dt.Rows[e.RowIndex][1].ToString());
                BookName = dt.Rows[e.RowIndex][2].ToString();
                Booknameıd = Int32.Parse(dt.Rows[e.RowIndex][1].ToString());

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                        MessageBox.Show(fullname, "Student Name", MessageBoxButtons.OK);
                    }

                }

                catch
                {
                    MessageBox.Show("Student Not Found", "NOT FOUND", MessageBoxButtons.OK);
                }
                SqlCommand afk = new SqlCommand();
                afk.Connection = con;
                ;

                afk.CommandText = "select * from Borrow_List where userid =" + result;
                SqlDataAdapter af = new SqlDataAdapter(afk);
                DataSet dl = new DataSet();
                af.Fill(dl);
                dataGridView1.DataSource = dl.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns["booknameid"].Visible = false;
                dataGridView1.Columns["userid"].Visible = false;
            }
        }

        private void borrow_textBox_TextChanged(object sender, EventArgs e)
        {

            if (borrow_textBox.Text != "")
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Borrow_List where bookname LIKE '" + borrow_textBox.Text + "%'and userid =" + result;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns["booknameid"].Visible = false;
                dataGridView1.Columns["userid"].Visible = false;

            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                ;

                cmd.CommandText = "select * from Borrow_List where userid =" + result;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.Columns["booknameid"].Visible = false;
                dataGridView1.Columns["userid"].Visible = false;

            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

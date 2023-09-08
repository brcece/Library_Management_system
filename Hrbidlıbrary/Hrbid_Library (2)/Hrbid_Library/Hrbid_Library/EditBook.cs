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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private int stock { get; set; }
        private int BookID { get; set; }
        private string BookName { get; set; }
        private string Author { get; set; }
        private int sstock { get; set; }

        private string bookname { get; set; }

        private int result { get; set; }
        private string Ttype { get; set; }
        private int Numberofpages { get; set; }
        private string Timee { get; set; }


        private bool read;

        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void textBookname_TextChanged(object sender, EventArgs e)
        {
            if (textBookname.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BooksList where book_name LIKE '" + textBookname.Text +
                                  "%' or author LIKE '" + textBookname.Text + "%' or type LIKE '" + textBookname.Text +
                                  "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                search_dataGridView1.DataSource = ds.Tables[0];
                search_dataGridView1.Columns["id"].Visible = false;
                search_dataGridView1.Columns["stock"].Visible = false;
                search_dataGridView1.AllowUserToAddRows = false;

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BooksList";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                search_dataGridView1.DataSource = ds.Tables[0];
                search_dataGridView1.Columns["id"].Visible = false;
                search_dataGridView1.AllowUserToAddRows = false;



            }
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =
                "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BooksList";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.Columns["stock"].Visible = false;
            search_dataGridView1.AllowUserToAddRows = false;
            con.Close();




        }

        private void search_dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {




        }

        private void search_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = search_dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                BookID = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
                BookName = dt.Rows[e.RowIndex][1].ToString();
                Author = dt.Rows[e.RowIndex][2].ToString();
                Ttype = dt.Rows[e.RowIndex][3].ToString();
                Numberofpages = Int32.Parse(dt.Rows[e.RowIndex][4].ToString());
                Timee = dt.Rows[e.RowIndex][5].ToString();
                sstock = Int32.Parse(dt.Rows[e.RowIndex][6].ToString());

                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                con.Open();
                SqlCommand dls =
                    new SqlCommand(
                        "select * from BooksList where id =" + BookID, con);
                SqlDataAdapter dl = new SqlDataAdapter(dls);
                DataSet df = new DataSet();




                dl.Fill(df);
                full_textBox1.Text = df.Tables[0].Rows[0]["book_name"].ToString();
                user_textBox2.Text = df.Tables[0].Rows[0]["author"].ToString();
                mail_textBox4.Text = df.Tables[0].Rows[0]["type"].ToString();
                mail_textBox3.Text = df.Tables[0].Rows[0]["number_of_pages"].ToString();

                textBox1.Text = df.Tables[0].Rows[0]["time"].ToString();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand komut = new SqlCommand(
                "UPDATE BooksList SET book_name = '" + full_textBox1.Text + "', author='" + user_textBox2.Text +
                "', type='" + mail_textBox4.Text + "', number_of_pages='" + mail_textBox3.Text + "', time ='" + textBox1.Text + "'where id=" + BookID, con);

            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You changed book informations", "Chaned", MessageBoxButtons.OK);

            textBookname.Text = "";
            full_textBox1.Text = "";
            user_textBox2.Text = "";
            mail_textBox3.Text = "";
            mail_textBox4.Text = "";
            textBox1.Text = "";

            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BooksList";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BookName == null)
            {
                
                MessageBox.Show("You Did Not Choose", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want to Delete It??", "You Are About to Delete",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    con.Open();
                    SqlCommand komut =
                        new SqlCommand(
                            "DELETE FROM BooksList WHERE book_name=@book_name AND author=@author AND type=@type AND number_of_pages=@number_of_pages AND time=@time AND stock=@stock",
                            con);
                    komut.Parameters.AddWithValue(("@book_name"), BookName);
                    komut.Parameters.AddWithValue(("@author"), Author);
                    komut.Parameters.AddWithValue(("@type"), Ttype);
                    komut.Parameters.AddWithValue(("@number_of_pages"), Numberofpages);
                    komut.Parameters.AddWithValue(("@time"), Timee);
                    komut.Parameters.AddWithValue(("@stock"), sstock);
                    komut.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(BookName, "Deleted", MessageBoxButtons.OK);
                }
            }

            full_textBox1.Text = "";
            user_textBox2.Text = "";
            mail_textBox3.Text = "";
            mail_textBox4.Text = "";
            textBox1.Text = "";
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BooksList";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.Columns["stock"].Visible = false;
            search_dataGridView1.AllowUserToAddRows = false;
            con.Close();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void full_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

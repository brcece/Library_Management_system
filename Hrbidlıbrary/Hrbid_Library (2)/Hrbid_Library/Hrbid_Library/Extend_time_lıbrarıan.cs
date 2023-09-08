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
    public partial class Extend_time_lıbrarıan : Form
    {
        public Extend_time_lıbrarıan()
        {
            InitializeComponent();
        }
        private int BorrowID { get; set; }
        private string BookName { get; set; }
        private int result { get; set; }

        private int Booknameıd { get; set; }
        private string fullname { get; set; }
        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
                TIME_dataGridView1.DataSource = dl.Tables[0];
                TIME_dataGridView1.Columns["id"].Visible = false;
                TIME_dataGridView1.AllowUserToAddRows = false;
                TIME_dataGridView1.Columns["booknameid"].Visible = false;
                TIME_dataGridView1.Columns["userid"].Visible = false;

            }
        }

        private void time_textBox_TextChanged(object sender, EventArgs e)
        {
            if (time_textBox.Text != "")
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                ;

                cmd.CommandText = "select * from Borrow_List where bookname LIKE '" + time_textBox.Text + "%' and userid =" + result;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                TIME_dataGridView1.DataSource = ds.Tables[0];
                TIME_dataGridView1.Columns["id"].Visible = false;
                TIME_dataGridView1.AllowUserToAddRows = false;
                TIME_dataGridView1.Columns["booknameid"].Visible = false;
                TIME_dataGridView1.Columns["userid"].Visible = false;

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
                TIME_dataGridView1.DataSource = ds.Tables[0];
                TIME_dataGridView1.Columns["id"].Visible = false;
                TIME_dataGridView1.AllowUserToAddRows = false;
                TIME_dataGridView1.Columns["booknameid"].Visible = false;
                TIME_dataGridView1.Columns["userid"].Visible = false;

            }
        }

        private void TIME_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = TIME_dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                BorrowID = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
                BookName = dt.Rows[e.RowIndex][2].ToString();
                Booknameıd = Int32.Parse(dt.Rows[e.RowIndex][1].ToString());

            }
        }

        private void time_button_change_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand komut = new SqlCommand("UPDATE Borrow_List SET endingtime = '" + time_dateTimePickerended.Text + "' WHERE id = " + BorrowID, con);

            komut.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(time_dateTimePickerended.Text, "Chaned The Returning Time to ", MessageBoxButtons.OK);

            con.Open();

            SqlCommand ls = new SqlCommand("UPDATE Borrow__history SET endingtime = '" + time_dateTimePickerended.Text + "' WHERE booknameid = " + Booknameıd, con);

            ls.ExecuteNonQuery();
            con.Close();
        }

        private void button_another_Click(object sender, EventArgs e)
        {
            time_textBox.Text = "";
            studentID_textBox2.Text = "";
            TIME_dataGridView1.DataSource = null;
            TIME_dataGridView1.Rows.Clear();
        }

        private void Extend_time_lıbrarıan_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}

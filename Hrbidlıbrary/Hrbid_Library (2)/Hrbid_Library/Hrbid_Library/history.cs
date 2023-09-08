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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
        private int flag = -1;

        private bool returned;
        private bool returedd ;
        private int BookID { get; set; }
        private string fullname { get; set; }
        private int studentID { get; set; }

        private string BookName { get; set; }

        private string studentname { get; set; }

        private string startedtime { get; set; }

        private string endingtime { get; set; }
        private void history_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Borrow__history ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["booknameid"].Visible = false;
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (studentID_textBox2.Text != "")
            {
                try

                {
                    try
                    {


                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "select * from Borrow__history where  studentID LIKE '" +
                                          int.Parse(studentID_textBox2.Text) +
                                          "%'";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["booknameid"].Visible = false;
                        dataGridView1.Columns["userid"].Visible = false;
                        dataGridView1.AllowUserToAddRows = false;




                    }
                    catch
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "select * from Borrow__history where (bookname LIKE '" + studentID_textBox2.Text +
                                          "%' or studentname LIKE '" + studentID_textBox2.Text + "%') ";
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Columns["id"].Visible = false;
                        dataGridView1.Columns["booknameid"].Visible = false;
                        dataGridView1.Columns["userid"].Visible = false;
                        dataGridView1.AllowUserToAddRows = false;




                    }

                }

                catch
                {
                    MessageBox.Show("Student Not Found", "NOT FOUND", MessageBoxButtons.OK);
                }

            }
            else
            {
                SqlCommand afk = new SqlCommand();
                afk.Connection = con;
                ;

                afk.CommandText = "select * from Borrow__history ";
                SqlDataAdapter af = new SqlDataAdapter(afk);
                DataSet dl = new DataSet();
                af.Fill(dl);
                dataGridView1.DataSource = dl.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["booknameid"].Visible = false;
                dataGridView1.Columns["userid"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            flag *= -1;
            if (flag == 1)
                panel3.Hide();
            else
            {
                panel3.Show();
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletRecordToolStripMenuItem_Click(object sender, EventArgs e)
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
                            "DELETE FROM Borrow__history WHERE bookname=@bookname AND studentname=@studentname AND studentID=@studentID",
                            con);
                    komut.Parameters.AddWithValue(("@bookname"), BookName);
                    komut.Parameters.AddWithValue(("@studentname"), studentname);
                    komut.Parameters.AddWithValue(("@studentID"), studentID);
                    //komut.Parameters.AddWithValue(("@startedtime"), startedtime);
                    //komut.Parameters.AddWithValue(("@ending"), endingtime);
                    //komut.Parameters.AddWithValue(("@isitreturn"), returned);
                    komut.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(BookName, "Deleted", MessageBoxButtons.OK);
                }
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Borrow__history";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["booknameid"].Visible = false;
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                BookID = Int32.Parse(dt.Rows[e.RowIndex][1].ToString());
                studentID = Int32.Parse(dt.Rows[e.RowIndex][5].ToString());
                BookName = dt.Rows[e.RowIndex][2].ToString();
                studentname = dt.Rows[e.RowIndex][4].ToString();
                startedtime = dt.Rows[e.RowIndex][6].ToString();
                endingtime = dt.Rows[e.RowIndex][7].ToString();
                returned = Boolean.Parse(dt.Rows[e.RowIndex][8].ToString());

                con.Open();
                SqlCommand dls =
                    new SqlCommand(
                        "select * from Borrow__history where booknameid =" + BookID, con);
                SqlDataAdapter dl = new SqlDataAdapter(dls);
                DataSet df = new DataSet();


                flag *= -1;
                if (flag == 1)
                    panel3.Hide();
                else
                {
                    panel3.Show();
                }



                dl.Fill(df);
                textBox1.Text = df.Tables[0].Rows[0]["bookname"].ToString();
                textBox2.Text = df.Tables[0].Rows[0]["studentname"].ToString();
                textBox3.Text = df.Tables[0].Rows[0]["studentID"].ToString();
                dateTimePicker2.Text = df.Tables[0].Rows[0]["startedtime"].ToString();
                dateTimePicker1.Text = df.Tables[0].Rows[0]["endingtime"].ToString();

                if (returned==true)
                {
                    label8.Text = "Returned";
                }
                else
                {
                    label8.Text = "Not Returned";
                }
                con.Close();


            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            returedd = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            returedd = !radioButton2.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand komut = new SqlCommand(
                "UPDATE Borrow__history SET bookname = '" + textBox1.Text + "', studentname='" + textBox2.Text +
                "', studentID=" + textBox3.Text + ", startedtime='" + dateTimePicker2.Text + "', endingtime ='" + dateTimePicker1.Text + "' , isitreturn = '" + returedd + "' WHERE booknameid = " + BookID, con); 

            komut.ExecuteNonQuery();
            con.Close();

            //con.Open();

            //SqlCommand dis = new SqlCommand("UPDATE Borrow__history SET 


            //dis.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("You changed book informations", "Chaned", MessageBoxButtons.OK);

            //textBookname.Text = "";
            //full_textBox1.Text = "";
            //user_textBox2.Text = "";
            //mail_textBox3.Text = "";
            //mail_textBox4.Text = "";
            //textBox1.Text = "";
            flag *= -1;
            if (flag == 1)
                panel3.Hide();
            else
            {
                panel3.Show();
            }


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Borrow__history";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["booknameid"].Visible = false;
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;

            con.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel3.Hide();
            else
            {
                panel3.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

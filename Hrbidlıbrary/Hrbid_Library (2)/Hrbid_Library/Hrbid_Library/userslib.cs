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
    public partial class userslib : Form
    {
        public userslib()
        {
            InitializeComponent();
        }

        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private int roleid { get; set; }
        private int id { get; set; }
        private int studentID { get; set; }

        private string fullname { get; set; }

        private string username { get; set; }

        private string birthday { get; set; }

        private string email { get; set; }
        private int flag = -1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from userTable where (fullname LIKE '" + textBox1.Text +
                                  "%' or username LIKE '" + textBox1.Text + "%' ) and roleid = 3 ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["pass"].Visible = false;
                dataGridView1.Columns["roleid"].Visible = false;
                dataGridView1.Columns["studentID"].Visible = false;

                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from userTable where roleid = 3";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["pass"].Visible = false;
                dataGridView1.Columns["roleid"].Visible = false;
                dataGridView1.Columns["studentID"].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                con.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void userslib_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 3";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["pass"].Visible = false;
            dataGridView1.Columns["roleid"].Visible = false;
            dataGridView1.Columns["studentID"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fullname == null)
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
                            "DELETE FROM userTable WHERE fullname=@fullname AND username=@username AND birthday=@birthday AND email=@email ",
                            con);
                    komut.Parameters.AddWithValue(("@fullname"), fullname);
                    komut.Parameters.AddWithValue(("@username"), username);
                    komut.Parameters.AddWithValue(("@birthday"), birthday);
                    komut.Parameters.AddWithValue(("@email"), email);


                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(fullname, "Deleted", MessageBoxButtons.OK);
                }
            }

            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 3";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["pass"].Visible = false;
            dataGridView1.Columns["roleid"].Visible = false;
            dataGridView1.Columns["studentID"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel4.Hide();
            else
            {
                panel4.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roleid = 3;
            if (checkBox1.Checked)
            {
                roleid = 1;



            }

            con.Open();
            SqlCommand komut =
                new SqlCommand(
                    "UPDATE userTable SET fullname = '" + textBox7.Text + "' , username='" + textBox6.Text +
                    "', birthday='" + textBox5.Text + "', email='" + textBox4.Text + "',roleid =" + roleid +
                    " where id =" + id, con);

            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You changed your informations", "Chaned", MessageBoxButtons.OK);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 3";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["pass"].Visible = false;
            dataGridView1.Columns["roleid"].Visible = false;
            dataGridView1.Columns["studentID"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            con.Close();
            if (checkBox1.Checked)
            {
                flag *= -1;
                if (flag == 1)
                    panel6.Hide();
                else
                {
                    panel6.Show();
                }



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                id = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
                roleid = Int32.Parse(dt.Rows[e.RowIndex][7].ToString());
                fullname = dt.Rows[e.RowIndex][1].ToString();
                username = dt.Rows[e.RowIndex][2].ToString();
                birthday = dt.Rows[e.RowIndex][3].ToString();
                email = dt.Rows[e.RowIndex][4].ToString();
                studentID = Int32.Parse(dt.Rows[e.RowIndex][6].ToString());
                roleid = 3;
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                con.Open();
                SqlCommand dls =
                    new SqlCommand(
                        "select * from userTable where roleid =" + roleid, con);
                SqlDataAdapter dl = new SqlDataAdapter(dls);
                DataSet df = new DataSet();


                dl.Fill(df);
                textBox7.Text = df.Tables[0].Rows[e.RowIndex]["fullname"].ToString();
                textBox6.Text = df.Tables[0].Rows[e.RowIndex]["username"].ToString();
                textBox5.Text = df.Tables[0].Rows[e.RowIndex]["birthday"].ToString();
                textBox4.Text = df.Tables[0].Rows[e.RowIndex]["email"].ToString();



                con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (
                    String.IsNullOrWhiteSpace(textBox7.Text) ||
                    String.IsNullOrWhiteSpace(textBox6.Text) ||
                    String.IsNullOrWhiteSpace(textBox5.Text) ||
                    String.IsNullOrWhiteSpace(textBox4.Text) ||
                    String.IsNullOrWhiteSpace(textBox10.Text))
                {
                    MessageBox.Show("Can Not Left Blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    

                    con.Open();
                    SqlCommand komut =
                        new SqlCommand(
                            "insert into userTable(fullname,username,birthday,email,pass,studentID,roleid)values(@fullname,@username,@birthday,@email,@pass,@studentID,@roleid)",
                            con);
                    komut.Parameters.AddWithValue(("@fullname"), textBox7.Text);
                    komut.Parameters.AddWithValue(("@username"), textBox6.Text);
                    komut.Parameters.AddWithValue(("@birthday"), textBox5.Text);
                    komut.Parameters.AddWithValue(("@email"), textBox4.Text);
                    komut.Parameters.AddWithValue(("@pass"), textBox10.Text);
                    komut.Parameters.AddWithValue(("@studentID"), 0);
                    komut.Parameters.AddWithValue(("@roleid"), roleid);
                    komut.ExecuteNonQuery();
                    con.Close();
                    //SqlDataAdapter da = new SqlDataAdapter(komut);
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "userTable");
                    MessageBox.Show("Successful", "Complated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control item in Controls)

                    {
                        if (item is TextBox)
                        {
                            item.Text = "<3 <3 <3";
                        }


                    }

                    flag *= -1;
                    if (flag == 1)
                        panel4.Hide();
                    else
                    {
                        panel4.Show();
                    }
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from userTable where roleid = 3";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns["pass"].Visible = false;
                    dataGridView1.Columns["roleid"].Visible = false;
                    dataGridView1.Columns["studentID"].Visible = false;
                    dataGridView1.AllowUserToAddRows = false;
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Unsuccessful", "Not Complated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            flag *= -1;
            if (flag == 1)
                panel4.Hide();
            else
            {
                panel4.Show();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 3";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["pass"].Visible = false;
            dataGridView1.Columns["roleid"].Visible = false;
            dataGridView1.Columns["studentID"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns["id"].Visible = false;
            dataGridView2.Columns["pass"].Visible = false;
            dataGridView2.Columns["roleid"].Visible = false;
            dataGridView2.Columns["studentID"].Visible = false;
            dataGridView2.AllowUserToAddRows = false;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel6.Hide();
            else
            {
                panel6.Show();
            }

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

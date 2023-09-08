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
    public partial class usersstudent : Form
    {
        public usersstudent()
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

        private  string birthday { get; set; }

        private string email { get;set; }
        private int flag = -1;
        private void users_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 2";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.Columns["pass"].Visible = false;
            search_dataGridView1.Columns["roleid"].Visible = false;
            search_dataGridView1.AllowUserToAddRows = false;


            




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBookname_TextChanged(object sender, EventArgs e)
        {
            if (textBookname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString =
                        "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from userTable where  studentID LIKE '" + int.Parse(textBookname.Text) +
                                      "%' and roleid = 2 ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    search_dataGridView1.DataSource = ds.Tables[0];
                    search_dataGridView1.Columns["id"].Visible = false;
                    search_dataGridView1.Columns["pass"].Visible = false;
                    search_dataGridView1.Columns["roleid"].Visible = false;

                    search_dataGridView1.AllowUserToAddRows = false;
                }
                catch
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString =
                        "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select * from userTable where (fullname LIKE '" + textBookname.Text +
                                      "%' or username LIKE '"+textBookname.Text + "%' ) and roleid = 2 ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    search_dataGridView1.DataSource = ds.Tables[0];
                    search_dataGridView1.Columns["id"].Visible = false;
                    search_dataGridView1.Columns["pass"].Visible = false;
                    search_dataGridView1.Columns["roleid"].Visible = false;

                    search_dataGridView1.AllowUserToAddRows = false;
                }

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString =
                    "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from userTable where roleid = 2";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                search_dataGridView1.DataSource = ds.Tables[0];
                search_dataGridView1.Columns["id"].Visible = false;
                search_dataGridView1.Columns["pass"].Visible = false;
                search_dataGridView1.Columns["roleid"].Visible = false;
                search_dataGridView1.AllowUserToAddRows = false;



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void search_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = search_dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)

            {
                id = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
                roleid = Int32.Parse(dt.Rows[e.RowIndex][7].ToString());
                fullname = dt.Rows[e.RowIndex][1].ToString();
                username = dt.Rows[e.RowIndex][2].ToString();
                birthday = dt.Rows[e.RowIndex][3].ToString();
                email = dt.Rows[e.RowIndex][4].ToString();
                studentID = Int32.Parse(dt.Rows[e.RowIndex][6].ToString());
                roleid = 2;
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
                full_textBox1.Text = df.Tables[0].Rows[e.RowIndex]["fullname"].ToString();
                user_textBox2.Text = df.Tables[0].Rows[e.RowIndex]["username"].ToString();
                mail_textBox4.Text = df.Tables[0].Rows[e.RowIndex]["birthday"].ToString();
                mail_textBox3.Text = df.Tables[0].Rows[e.RowIndex]["email"].ToString();
                textBox2.Text = df.Tables[0].Rows[e.RowIndex]["studentID"].ToString();

                
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand komut = new SqlCommand("UPDATE userTable SET fullname = '" + full_textBox1.Text + "',studentID='" + textBox2.Text + "', username='" + user_textBox2.Text + "', birthday='" + mail_textBox4.Text + "', email='" + mail_textBox3.Text + "'where id ="+id , con);

            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("You changed your informations", "Chaned", MessageBoxButtons.OK);
            textBookname.Text = "";
            full_textBox1.Text = "";
            user_textBox2.Text = "";
            mail_textBox3.Text = "";
            mail_textBox4.Text = "";
            textBox2.Text = "";

            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 2";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.Columns["pass"].Visible = false;
            search_dataGridView1.Columns["roleid"].Visible = false;

            search_dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
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
                            "DELETE FROM userTable WHERE fullname=@fullname AND username=@username AND birthday=@birthday AND email=@email AND studentID=@studentID ",
                            con);
                    komut.Parameters.AddWithValue(("@fullname"), fullname);
                    komut.Parameters.AddWithValue(("@username"), username);
                    komut.Parameters.AddWithValue(("@birthday"), birthday);
                    komut.Parameters.AddWithValue(("@email"), email);
                    komut.Parameters.AddWithValue(("@studentID"), studentID);

                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(fullname, "Deleted", MessageBoxButtons.OK);
                }
            }

            full_textBox1.Text = "";
            user_textBox2.Text = "";
            mail_textBox3.Text = "";
            mail_textBox4.Text = "";
            textBox2.Text = "";
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from userTable where roleid = 2";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.Columns["pass"].Visible = false;
            search_dataGridView1.Columns["roleid"].Visible = false;

            search_dataGridView1.AllowUserToAddRows = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                panel4.Hide();
            else
            {
                panel4.Show();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

            cmd.CommandText = "select * from userTable where roleid = 2";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.Columns["pass"].Visible = false;
            search_dataGridView1.Columns["roleid"].Visible = false;
            
            search_dataGridView1.AllowUserToAddRows = false;
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(full_textBox1.Text) || String.IsNullOrWhiteSpace(user_textBox2.Text) || String.IsNullOrWhiteSpace(mail_textBox4.Text) || String.IsNullOrWhiteSpace(mail_textBox3.Text) || String.IsNullOrWhiteSpace(textBox10.Text))
                {
                    MessageBox.Show("Can Not Left Blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    con.Open();
                    SqlCommand komut = new SqlCommand("insert into userTable(fullname,username,birthday,email,pass,studentID,roleid)values(@fullname,@username,@birthday,@email,@pass,@studentID,@roleid)", con);
                    komut.Parameters.AddWithValue(("@fullname"), full_textBox1.Text);
                    komut.Parameters.AddWithValue(("@username"), user_textBox2.Text);
                    komut.Parameters.AddWithValue(("@birthday"), mail_textBox4.Text);
                    komut.Parameters.AddWithValue(("@email"), mail_textBox3.Text);
                    komut.Parameters.AddWithValue(("@pass"), textBox10.Text);
                    komut.Parameters.AddWithValue(("@studentID"), textBox2.Text);
                    komut.Parameters.AddWithValue(("@roleid"), roleid = 2);
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

                    cmd.CommandText = "select * from userTable where roleid = 2";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    search_dataGridView1.DataSource = ds.Tables[0];
                    search_dataGridView1.Columns["id"].Visible = false;
                    search_dataGridView1.Columns["pass"].Visible = false;
                    search_dataGridView1.Columns["roleid"].Visible = false;
                    
                    search_dataGridView1.AllowUserToAddRows = false;
                    con.Close();

                }
            }
            catch
            {
                MessageBox.Show("Unsuccessful", "Not Complated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

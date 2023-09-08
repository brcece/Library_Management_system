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
    public partial class myacountmanager : Form
    {
        private SqlConnection baglantı;
        private int id { get; set; }
        private string fullname { get; set; }
        private string username { get; set; }
        private string birthday { get; set; }

        private string email { get; set; }

        private int studentid { get; set; }
        public myacountmanager()
        {
            InitializeComponent();
            baglantı = new SqlConnection(
                "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
            baglantı.Open();
        }
        private int roleid { get; set; }
        private void myacountmanager_Load(object sender, EventArgs e)
        {
            SqlCommand cmd =
                new SqlCommand(
                    "select * from [userTable] where  id =" + Program.CurrrentUserID, baglantı);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();




            da.Fill(ds);
            full_textBox1.Text = ds.Tables[0].Rows[0]["fullname"].ToString();
            
            user_textBox2.Text = ds.Tables[0].Rows[0]["username"].ToString();
            mail_textBox3.Text = ds.Tables[0].Rows[0]["birthday"].ToString();
            mail_textBox4.Text = ds.Tables[0].Rows[0]["email"].ToString();

            id = (int)ds.Tables[0].Rows[0]["roleid"];
            fullname = ds.Tables[0].Rows[0]["fullname"].ToString();
            username = ds.Tables[0].Rows[0]["username"].ToString();
            birthday = ds.Tables[0].Rows[0]["birthday"].ToString();
            email = ds.Tables[0].Rows[0]["email"].ToString();
            studentid = (int)ds.Tables[0].Rows[0]["studentID"];

            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roleid = 1;
            if (checkBox1.Checked)
            {
                roleid = 3;
            }
            
            baglantı.Open();

            SqlCommand komut = new SqlCommand("UPDATE userTable SET fullname = '" + full_textBox1.Text +  "', username='" + user_textBox2.Text + "', birthday='" + mail_textBox3.Text + "', email='" + mail_textBox4.Text + "',roleid="+roleid+"where id =" + Program.CurrrentUserID, baglantı);

            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("You changed your informations", "Chaned", MessageBoxButtons.OK);
            if (checkBox1.Checked)
            {

                manager dash = new manager();
                dash.Show();
                this.Owner.Close();
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_pass dash =new change_pass();
            dash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            baglantı.Open();
            SqlCommand komut =
                new SqlCommand(
                    "DELETE FROM userTable WHERE fullname=@fullname AND username=@username AND birthday=@birthday AND email=@email AND studentID=@studentID AND roleid =@roleid AND id =" +
                    Program.CurrrentUserID,
                    baglantı);
            komut.Parameters.AddWithValue(("@fullname"), fullname);
            komut.Parameters.AddWithValue(("@username"), username);
            komut.Parameters.AddWithValue(("@birthday"), birthday);
            komut.Parameters.AddWithValue(("@email"), email);
            komut.Parameters.AddWithValue(("@roleid"), id);
            komut.Parameters.AddWithValue(("@studentID"), studentid);

            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(full_textBox1.Text, "Deleted", MessageBoxButtons.OK);


            full_textBox1.Text = "";
            user_textBox2.Text = "";
            mail_textBox3.Text = "";
            mail_textBox4.Text = "";
            

            baglantı.Close();
            manager dash = new manager();
            dash.Show();
            this.Owner.Close();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

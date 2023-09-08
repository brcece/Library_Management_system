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
    public partial class Editmyprofile : Form
    {
        private SqlConnection baglantı;
        public Editmyprofile()
        {
            InitializeComponent();
            baglantı = new SqlConnection(
                "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
            baglantı.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_pass sngup = new change_pass();
            sngup.Show();
            this.Hide();
        }

        private void Editmyprofile_Load(object sender, EventArgs e)
        {



            SqlCommand cmd =
                new SqlCommand(
                    "select * from [userTable] where  id =" + Program.CurrrentUserID, baglantı);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            
       

           
            da.Fill(ds);
            full_textBox1.Text = ds.Tables[0].Rows[0]["fullname"].ToString();
            textBox1.Text = ds.Tables[0].Rows[0]["studentID"].ToString();
            user_textBox2.Text = ds.Tables[0].Rows[0]["username"].ToString();
            mail_textBox3.Text = ds.Tables[0].Rows[0]["birthday"].ToString();
            mail_textBox4.Text = ds.Tables[0].Rows[0]["email"].ToString();
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();

            SqlCommand komut = new SqlCommand("UPDATE userTable SET fullname = '" + full_textBox1.Text + "',studentID='"+textBox1.Text+"', username='"+user_textBox2.Text+"', birthday='"+mail_textBox3.Text+ "', email='" + mail_textBox4.Text+"'where id =" + Program.CurrrentUserID, baglantı);

            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("You changed your informations", "Chaned", MessageBoxButtons.OK);
        }

        private void full_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

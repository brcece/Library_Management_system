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
    public partial class ForgotPass : Form
    {
        private SqlConnection baglantı;

        public ForgotPass()
        {
            InitializeComponent();


            baglantı = new SqlConnection(
                "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
            baglantı.Open();

        }

        private void ForgotPass_Load(object sender, EventArgs e)
            {

            }
        

        private void SingUp_button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To EXIT?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void forgot_button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Cancel?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                first_page frm1 = new first_page();
                frm1.Show();
                this.Hide();
            }
            
        }

        private void forgot_textBox1_userName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void forgot_textBox1_userName_MouseClick(object sender, MouseEventArgs e)
        {
            if (forgot_textBox1_userName.Text == "Username")
            {
                forgot_textBox1_userName.Clear();

            }
        }

        private void forgot_textBox2_email_MouseEnter(object sender, EventArgs e)
        {

        }

        private void forgot_textBox2_email_MouseClick(object sender, MouseEventArgs e)
        {
            if (forgot_textBox2_email.Text == "E-Mail")
            {
                forgot_textBox2_email.Clear();

            }
        }

        private void forgot_textBox3_newpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgot_textBox3_newpass_MouseEnter(object sender, EventArgs e)
        {

        }

        private void forgot_textBox3_newpass_MouseClick(object sender, MouseEventArgs e)
        {
            if (forgot_textBox3_newpass.Text == "New Password")
            {
                forgot_textBox3_newpass.Clear();

            }
        }

        private void forgot_textBox4_newpassagain_MouseEnter(object sender, EventArgs e)
        {

        }

        private void forgot_textBox4_newpassagain_MouseClick(object sender, MouseEventArgs e)
        {
            if (forgot_textBox4_newpassagain.Text == "New Password Again")
            {
                forgot_textBox4_newpassagain.Clear();

            }
        }

        private void forgot_button1_Changepass_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglantı;
            
            cmd.CommandText = "select * from userTable where username = '" + forgot_textBox1_userName.Text + "' and email ='" + forgot_textBox2_email.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "userTable");
            if (ds.Tables[0].Rows.Count>0)
            {
                if (forgot_textBox3_newpass.Text==forgot_textBox4_newpassagain.Text)
                {
                    SqlConnection con = new SqlConnection(MySql.conString);
                    con.ConnectionString = "data source=DESKTOP-3IS66MI\\HRBİD;database=Library;Integrated Security=True";
                   
                    

                    try
                    {
                        SqlCommand komut = new SqlCommand("UPDATE userTable SET pass = '"+ forgot_textBox3_newpass.Text+"' WHERE email = '"+forgot_textBox2_email.Text+"'", baglantı);
                        
                        komut.ExecuteNonQuery();
                        
                        MessageBox.Show("Password Changed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("user not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void forgot_button1_login_Click(object sender, EventArgs e)
        {
            first_page frm1 = new first_page();
            frm1.Show();
            this.Hide();
        }
    }
}

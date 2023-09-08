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
using System.Windows.Forms.VisualStyles;


namespace Hrbid_Library
{
    public partial class Form1 : Form
    {
        private bool isactive = false;
        private string fullname = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        private void form1_button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To EXIT?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

                
            }
        }

        private void form1_pictureBox_2_Click(object sender, EventArgs e)
        {

        }

        private void form1_textbox_username_MouseClick(object sender, MouseEventArgs e)
        {
            if (form1_textbox_username.Text == "Username")
            {
                form1_textbox_username.Clear();

            }
        }
        private void form1_textBox_password_MouseEnter(object sender, EventArgs e)
        {

        }
        private void form1_textBox_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (form1_textBox_password.Text == "Password")
            {
                form1_textBox_password.Clear();
                form1_textBox_password.PasswordChar = '*';
            }
        }


        
        private void form_button_logın_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(MySql.conString);
                con.ConnectionString = "data source=DESKTOP-3IS66MI\\HRBİD;database=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from userTable where username = '" + form1_textbox_username.Text + "' and pass ='" + form1_textBox_password.Text + "' and roleid ='"+2+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds,"userTable");






                if (ds.Tables[0].Rows.Count != 0)
                {
                    Program.CurrrentUserID = Int32.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                    Dashboard dsa = new Dashboard();
                    dsa.Show();
                    dsa.label3.Text = ds.Tables[0].Rows[0]["fullname"].ToString();
                    this.Hide();
                    MessageBox.Show(form1_textbox_username.Text, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("An error occurred while establishing the connection", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        
        private void form1_button_sıngup_Click(object sender, EventArgs e)
        {   
            
            SingUp sngup = new SingUp();
            sngup.Show();
            this.Hide();

        }

        private void form1_textbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void form1_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass frm1 = new ForgotPass();
            frm1.Show();
            this.Hide();
        }

        private void form1_textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            first_page dash = new first_page();
            dash.Show();
            this.Hide();
        }
    }
}

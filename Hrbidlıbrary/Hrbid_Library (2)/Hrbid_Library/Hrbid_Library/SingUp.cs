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

    
    public partial class SingUp : Form
    {
       

        public SingUp()
        {
            InitializeComponent();
        }

        private int roleid { get; set; }

        private SqlConnection baglantı =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
        private void SingUp_Load(object sender, EventArgs e)
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

        private void SingUp_label_SingUp_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void SingUp_pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_Birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_FullName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_FullName_MouseClick(object sender, MouseEventArgs e)
        {
            if (SingUp_textBox_FullName.Text == "Full Name")
            {
                SingUp_textBox_FullName.Clear();

            }
        }

        private void SingUp_textBox_UserName_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (SingUp_textBox_UserName.Text == "Username")
            {
                SingUp_textBox_UserName.Clear();

            }
        }

        private void SingUp_dateTimePicker_1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_email_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_email_MouseClick(object sender, MouseEventArgs e)
        {
            if (SingUp_textBox_email.Text == "E-Mail")
            {
                SingUp_textBox_email.Clear();

            }
        }

        private void SingUp_textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_Password_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_Password_MouseClick(object sender, MouseEventArgs e)
        {
            if (SingUp_textBox_Password.Text == "Password")
            {
                SingUp_textBox_Password.Clear();

            }
        }

        private void SingUp_textBox_Birth_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SingUp_textBox_Birth_MouseClick(object sender, MouseEventArgs e)
        {
            if (SingUp_textBox_Birth.Text == "Birth Day")
            {
                SingUp_textBox_Birth.Clear();

            }
        }

        private void SingUp_button_Join_Click(object sender, EventArgs e)
        {

            try
            {
                if (SingUp_textBox_FullName.Text == "Full Name" || SingUp_textBox_UserName.Text == "Username" || SingUp_textBox_Birth.Text == "Birth Day" || SingUp_textBox_email.Text == "E-Mail" || SingUp_textBox_Password.Text == "Password" ||
                    String.IsNullOrWhiteSpace(SingUp_textBox_FullName.Text) || String.IsNullOrWhiteSpace(SingUp_textBox_UserName.Text) ||String.IsNullOrWhiteSpace(SingUp_textBox_Birth.Text) ||String.IsNullOrWhiteSpace(SingUp_textBox_email.Text) ||String.IsNullOrWhiteSpace(SingUp_textBox_Password.Text))
                {
                    MessageBox.Show("Can Not Left Blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                

                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("insert into userTable(fullname,username,birthday,email,pass,studentID,roleid)values(@fullname,@username,@birthday,@email,@pass,@studentID,@roleid)", baglantı);
                    komut.Parameters.AddWithValue(("@fullname"), SingUp_textBox_FullName.Text);
                    komut.Parameters.AddWithValue(("@username"), SingUp_textBox_UserName.Text);
                    komut.Parameters.AddWithValue(("@birthday"), SingUp_textBox_Birth.Text);
                    komut.Parameters.AddWithValue(("@email"), SingUp_textBox_email.Text);
                    komut.Parameters.AddWithValue(("@pass"), SingUp_textBox_Password.Text);
                    komut.Parameters.AddWithValue(("@studentID"), textBox1.Text);
                    komut.Parameters.AddWithValue(("@roleid"), roleid = 2);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    //SqlDataAdapter da = new SqlDataAdapter(komut);
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "userTable");
                    MessageBox.Show("Successful","Complated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    foreach (Control item in Controls)

                    {
                        if (item is TextBox)
                        {
                            item.Text = "<3 <3 <3";
                        }


                    }

                }
            }
            catch
            {
                MessageBox.Show("Unsuccessful", "Not Complated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SingUp_button_Login_Click(object sender, EventArgs e)
        {
            
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
            

        }

        private void SingUp_button_Join_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void SingUp_textBox_FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox1.Text == "Student ID")
            {
                textBox1.Clear();

            }
        }
    }
}

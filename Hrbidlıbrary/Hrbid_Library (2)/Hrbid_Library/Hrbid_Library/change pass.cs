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
    public partial class change_pass : Form
    {
        
        private SqlConnection baglantı;

        public change_pass()
        {
            InitializeComponent();

            baglantı = new SqlConnection(
                "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
            baglantı.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglantı;

            cmd.CommandText = "select * from userTable where pass = '" + OLD_textBox1.Text + "' and id =" + Program.CurrrentUserID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (NEW_textBox2.Text == NEWA_textBox3.Text)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=DESKTOP-3IS66MI\\HRBİD;database=Library;Integrated Security=True";



                    try
                    {
                        SqlCommand komut = new SqlCommand("UPDATE userTable SET pass = '" +NEW_textBox2.Text + "' WHERE  id = " + Program.CurrrentUserID, baglantı);

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
                MessageBox.Show("Password is wrong", "wrong pass", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void change_pass_Load(object sender, EventArgs e)
        {
            OLD_textBox1.PasswordChar = '*';
        }

        private void OLD_textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void OLD_textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
            OLD_textBox1.PasswordChar = '*';
            
        }

        private void OLD_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }


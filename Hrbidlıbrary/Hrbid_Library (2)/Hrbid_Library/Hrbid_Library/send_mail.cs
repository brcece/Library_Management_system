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
using System.Net.Mail;


namespace Hrbid_Library
{
    public partial class send_mail : Form
    {
        public send_mail()
        {
            InitializeComponent();
        }

        private DateTime tarih;
        private bool returned;
        private bool returedd;
        private int yyyy;
        private int mm;
        private int dd;
        private DateTime today;

        //private st end;
        private int BookID { get; set; }
        public static System.Text.Encoding UTF8 { get; }
        private string fullname { get; set; }
        private int studentID { get; set; }

        private string tablename;

        private string BookName { get; set; }

        private string studentname { get; set; }

        private string startedtime { get; set; }

        private string endingtime { get; set; }

        private string eMail { get; set; }

        private int userid { get; set; }


        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void send_mail_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            today = DateTime.Now.Date;

            cmd.CommandText = cmd.CommandText =
                "select * from Borrow__history where  CONVERT (datetime, endingtime,104) < CONVERT (datetime,'" +
                today + "',104) and isitreturn='"+returned+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["booknameid"].Visible = false;
            dataGridView1.Columns["userid"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
           

            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Visible = true;
                ;

            }
            else
            {
                label5.Visible = true;
            }
        }
    



        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                endingtime = dt.Rows[e.RowIndex][8].ToString();
                userid = Int32.Parse(dt.Rows[e.RowIndex][3].ToString());



                returned = Boolean.Parse(dt.Rows[e.RowIndex][8].ToString());
                returned = false;


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                today = DateTime.Now.Date;

                cmd.CommandText = cmd.CommandText =
                    "select * from Borrow__history where  CONVERT (datetime, endingtime,104) < CONVERT (datetime,'" +
                    today + "',104) and isitreturn='" + returned + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                label3.Text = dt.Rows[e.RowIndex][4].ToString();



                //tarih = DateTime.Now.ToShortTimeString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd =
                    new SqlCommand(
                        "select * from [userTable] where  id =" + userid, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                eMail = ds.Tables[0].Rows[0]["email"].ToString();
                MessageBox.Show(eMail, studentname);
                System.Diagnostics.Process.Start("https://write-box.appspot.com/");
            }
            catch
            {
                MessageBox.Show("You Did Not Choose");
            }

            
            //SmtpClient sc = new SmtpClient();
            //sc.Port = 587;
            //sc.Host = "smtp.office365.com";
            //sc.EnableSsl = true;

            //sc.Credentials = new System.Net.NetworkCredential("hrbidlib@hotmail.com", "STARTTLS");
            //MailMessage mesaj = new MailMessage("hrbidlib@hotmail.com", eMail);
            //mesaj.Subject = "The deadline for returning the book has passed.";
            //mesaj.Body = BookName;

            //sc.Send(mesaj);

            


        }
    }
}

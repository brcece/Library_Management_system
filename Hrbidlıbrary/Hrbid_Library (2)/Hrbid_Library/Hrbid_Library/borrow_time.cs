using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hrbid_Library
{
    public partial class borrow_time : Form
    {
        public borrow_time()
        {
            InitializeComponent();
        }

        private int BorrowID { get; set; }
        private string BookName { get; set; }

        private  int Booknameıd { get; set; }


        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
        private void borrow_time_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            ;

            cmd.CommandText = "select * from Borrow_List where userid =" + Program.CurrrentUserID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            TIME_dataGridView1.DataSource = ds.Tables[0];
            TIME_dataGridView1.Columns["id"].Visible = false;
            TIME_dataGridView1.AllowUserToAddRows = false;
            TIME_dataGridView1.Columns["booknameid"].Visible = false;
            TIME_dataGridView1.Columns["userid"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TIME_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = TIME_dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                BorrowID = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
                BookName = dt.Rows[e.RowIndex][2].ToString();
                Booknameıd = Int32.Parse(dt.Rows[e.RowIndex][1].ToString());

            }


        }

        private void time_textBox_TextChanged(object sender, EventArgs e)
        {
            if (time_textBox.Text != "")
            {

                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                ;

                cmd.CommandText = "select * from Borrow_List where bookname LIKE '" + time_textBox.Text + "%' and userid ="+Program.CurrrentUserID;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                TIME_dataGridView1.DataSource = ds.Tables[0];
                TIME_dataGridView1.Columns["id"].Visible = false;
                TIME_dataGridView1.AllowUserToAddRows = false;
                TIME_dataGridView1.Columns["booknameid"].Visible = false;
                TIME_dataGridView1.Columns["userid"].Visible = false;

                

            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                ;

                cmd.CommandText = "select * from Borrow_List where userid =" + Program.CurrrentUserID;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                TIME_dataGridView1.DataSource = ds.Tables[0];
                TIME_dataGridView1.Columns["id"].Visible = false;
                TIME_dataGridView1.AllowUserToAddRows = false;
                TIME_dataGridView1.Columns["booknameid"].Visible = false;
                TIME_dataGridView1.Columns["userid"].Visible = false;

            }
        }

        private void time_button_change_Click(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand komut = new SqlCommand("UPDATE Borrow_List SET endingtime = '" +time_dateTimePickerended.Text + "' WHERE id = "+BorrowID, con);

            komut.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand ls = new SqlCommand("UPDATE Borrow__history SET endingtime = '" + time_dateTimePickerended.Text + "' WHERE booknameid = " + Booknameıd, con);

            ls.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(time_dateTimePickerended.Text, "Chaned The Returning Time to ", MessageBoxButtons.OK);
            time_textBox.Text = "";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            ;

            cmd.CommandText = "select * from Borrow_List where bookname LIKE '" + time_textBox.Text + "%' and userid =" + Program.CurrrentUserID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            TIME_dataGridView1.DataSource = ds.Tables[0];
            TIME_dataGridView1.Columns["id"].Visible = false;
            TIME_dataGridView1.AllowUserToAddRows = false;
            TIME_dataGridView1.Columns["booknameid"].Visible = false;
            TIME_dataGridView1.Columns["userid"].Visible = false;


        }

        private void button_another_Click(object sender, EventArgs e)
        {
           
            



        }

        private void time_dateTimePickerended_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

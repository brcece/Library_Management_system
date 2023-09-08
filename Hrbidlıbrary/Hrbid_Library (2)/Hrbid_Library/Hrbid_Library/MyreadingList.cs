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
    public partial class MyreadingList : Form
    {
        public MyreadingList()
        {
            InitializeComponent();
        }

        private int ID { get; set; }

        private bool read;
        private SqlConnection kitap =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = kitap;
                ;
                cmd.CommandText = "select * from Read_List where Book_Name LIKE '" + textBox1.Text + "%' and userid =" +
                                  Program.CurrrentUserID;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Reading_dataGridView1.DataSource = ds.Tables[0];
                Reading_dataGridView1.Columns["id"].Visible = false;
                Reading_dataGridView1.AllowUserToAddRows = false;
                Reading_dataGridView1.Columns["bookid"].Visible = false;
                Reading_dataGridView1.Columns["userid"].Visible = false;

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MyreadingList_Load(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kitap;

            cmd.CommandText = "select * from Read_List where userid =" + Program.CurrrentUserID;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Reading_dataGridView1.DataSource = ds.Tables[0];
            Reading_dataGridView1.Columns["id"].Visible = false;
            Reading_dataGridView1.AllowUserToAddRows = false;
            Reading_dataGridView1.Columns["bookid"].Visible = false;
            Reading_dataGridView1.Columns["userid"].Visible = false;

            Reading_dataGridView1.DataSource = ds.Tables[0];





        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDBOOKMYLIST dash = new ADDBOOKMYLIST();
            dash.Show();
            this.Hide();
        }

        private void Reading_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = Reading_dataGridView1.DataSource as DataTable;
            if (e.RowIndex != -1)
            {
                ID = Int32.Parse(dt.Rows[e.RowIndex][0].ToString());
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            read = radioButton1.Checked;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            read = !radioButton2.Checked;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            kitap.Open();

            SqlCommand komut = new SqlCommand("UPDATE Read_List SET Read_or_Not_Read = '" + read + "' WHERE id = " + ID, kitap);

            komut.ExecuteNonQuery();
            kitap.Close();

            MessageBox.Show("Saved", "",MessageBoxButtons.OK);

            textBox1.Text = "";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kitap;

            cmd.CommandText = "select * from Read_List where userid =" + Program.CurrrentUserID;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Reading_dataGridView1.DataSource = ds.Tables[0];
            Reading_dataGridView1.Columns["id"].Visible = false;
            Reading_dataGridView1.AllowUserToAddRows = false;
            Reading_dataGridView1.Columns["bookid"].Visible = false;
            Reading_dataGridView1.Columns["userid"].Visible = false;

            Reading_dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_another_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Reading_dataGridView1.DataSource = null;
            Reading_dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
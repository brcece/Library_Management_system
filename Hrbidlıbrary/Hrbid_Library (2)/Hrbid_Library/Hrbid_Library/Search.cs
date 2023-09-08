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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BooksList";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            search_dataGridView1.DataSource = ds.Tables[0];
            search_dataGridView1.Columns["id"].Visible = false;
            search_dataGridView1.AllowUserToAddRows = false;

        }

        private void textBookname_TextChanged(object sender, EventArgs e)
        {
            if (textBookname.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BooksList where book_name LIKE '"+ textBookname.Text+ "%' or author LIKE '" + textBookname.Text + "%' or type LIKE '" + textBookname.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                search_dataGridView1.DataSource = ds.Tables[0];
                search_dataGridView1.Columns["id"].Visible = false;
                search_dataGridView1.Columns["stock"].Visible = false;
                search_dataGridView1.AllowUserToAddRows = false;

            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BooksList";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                search_dataGridView1.DataSource = ds.Tables[0];
                search_dataGridView1.Columns["id"].Visible = false;
                search_dataGridView1.AllowUserToAddRows = false;



            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void search_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from BooksList ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void borrow_panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

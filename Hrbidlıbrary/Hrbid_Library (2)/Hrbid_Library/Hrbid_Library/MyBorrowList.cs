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
    public partial class MyBorrowList : Form
    {
        public MyBorrowList()
        {
            InitializeComponent();
        }
        private SqlConnection con =
            new SqlConnection("Data Source=DESKTOP-3IS66MI\\HRBİD;Initial Catalog=Library;Integrated Security=True");
        private void MYBORROW_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void MyBorrowList_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            ;

            cmd.CommandText = "select * from Borrow_List where userid =" + Program.CurrrentUserID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MYBORROW_dataGridView1.DataSource = ds.Tables[0];
            MYBORROW_dataGridView1.Columns["id"].Visible = false;
            MYBORROW_dataGridView1.AllowUserToAddRows = false;
            MYBORROW_dataGridView1.Columns["booknameid"].Visible = false;
            MYBORROW_dataGridView1.Columns["userid"].Visible = false;

        }

        private void my_list_button_borrow_Click(object sender, EventArgs e)
        {
            Borrow_Books frm1 = new Borrow_Books();
            frm1.Show();
            this.Hide();
        }

        private void my_list_button_time_Click(object sender, EventArgs e)
        {
            borrow_time frm1 = new borrow_time();
            frm1.Show();
            this.Hide();
        }
    }
}

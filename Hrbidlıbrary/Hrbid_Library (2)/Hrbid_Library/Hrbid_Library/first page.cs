using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hrbid_Library
{
    public partial class first_page : Form
    {
        public first_page()
        {
            InitializeComponent();
        }

        private void first_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 dash = new Form1();
            dash.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LIBRARIAN dash = new LIBRARIAN();
            dash.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manager dash = new manager();
            dash.Show();
            this.Hide();
        }

        private void form1_button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To EXIT?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void form1_label_welcome_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using System.Configuration;

namespace Hospital_Management_System
{
    public partial class admin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand sqlcmd = new SqlCommand("Select COUNT(1) from Admin where Name=@Name AND Password=@Password", con);
            sqlcmd.Parameters.AddWithValue("@Name", TextBox1.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@Password", TextBox2.Text.Trim());


            int count = Convert.ToInt32(sqlcmd.ExecuteScalar());

            if (count == 1)
            {
                Menu menu = new Menu();
                menu.Show();
            }

            else
            {
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}

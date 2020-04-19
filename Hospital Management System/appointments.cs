using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Hospital_Management_System
{
    public partial class appointments : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;


        public appointments()
        {
            InitializeComponent();
        }
        private void doctors_Load(object sender, EventArgs e)
        {
            
        }
        private DataTable Appointment()
        {
            DataTable dtappointments = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Appointments", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtappointments.Load(reader);

                }

            }
            return dtappointments;
        }
        private void appointments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Appointment();
            Appointment();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

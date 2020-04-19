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
    public partial class patients : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;


        public patients()
        {
            InitializeComponent();
        }

        private void patients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Patientssdata();
            Patientssdata();
        }
        private DataTable Patientssdata()
        {
            DataTable dtdoctors = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Patients", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtdoctors.Load(reader);

                }

            }
            return dtdoctors;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

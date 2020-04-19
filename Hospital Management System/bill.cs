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
using Dapper;
using System.Configuration;

namespace Hospital_Management_System
{
    public partial class bill : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = new SqlConnection(cs))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string query = "select p.Name, d.Name, d.DocFees, a.ID, a.DateofAppointment, a.TimeofAppointment from Doctors d inner join Appointments a on a.DocID = d.Id inner join Patients p on p.ID = a.patientID " +
                        $"where a.DateofAppointment between '{fromdate.Value}' and '{ todate.Value}'";
                    billlsBindingSource.DataSource = db.Query<billls>(query, CommandType.Text);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using Dapper;
using System.Configuration;

namespace Hospital_Management_System
{
    public partial class bill_generate : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public bill_generate()
        {
            InitializeComponent();
        }

        private void bill_generate_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = new SqlConnection(cs))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string query = "select p.Name, d.Name, d.DocFees, a.DateofAppointment, a.TimeofAppointment from Doctors d inner join Appointments a on a.DocID = d.Id inner join Patients p on p.Id = a.PatientID " +
                        $"where a.DateofAppointment between '{fromdate.Value}' and '{ todate.Value}'";
                    billlsBindingSource.DataSource = db.Query<billls>(query, CommandType.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            billls obj = billlsBindingSource.Current as billls;
            if(obj != null)
            {
            using (SqlConnection db = new SqlConnection(cs))
                { 
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string query = "select p.Name, d.Name, d.DocFees, a.ID, a.DateofAppointment, a.TimeofAppointment from doctors d inner join appointments a on a.DocID = d.ID inner join patients p on p.ID = a.patientID " +
                            $"where a.ID = '{obj.ID}'";
                    List<bill_details> list = db.Query<bill_details>(query, CommandType.Text).ToList();
                        //using (print_form frm = new print_form(obj, list))
                        //{
                        //    frm.Show();
                        //}
                    }
             }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

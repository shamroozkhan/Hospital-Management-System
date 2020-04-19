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
    public partial class appointments_make : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public appointments_make()
        {
            InitializeComponent();
            Get_Docs_data();
            Get_Patients_Name();
            Get_Patients_Number();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void Get_Docs_data()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Doctors"; // you should use your table name .
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                docs_box.Text = "Select";
                docs_box.ValueMember = "DoctorsId";
                docs_box.DisplayMember = "Name";
                docs_box.DataSource = dtbl;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        void Get_Patients_Name()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Patients"; // you should use your table name .
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                patients_box.Text = "Select";
                patients_box.ValueMember = "PatientsId";
                patients_box.DisplayMember = "Name";
                patients_box.DataSource = dtbl;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        void Get_Patients_Number()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Patients"; // you should use your table name .
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                patients_phone.Text = "Select";
                patients_phone.ValueMember = "PatientsId";
                patients_phone.DisplayMember = "Phone";
                patients_phone.DataSource = dtbl;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void patients_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

        private void appointments_make_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("CreateAppointment", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parampatientname = new SqlParameter()
                {
                    ParameterName = "@DoctorName",
                    Value = docs_box.Text
                };
                cmd.Parameters.Add(parampatientname);

                SqlParameter paramdoctorname = new SqlParameter()
                {
                    ParameterName = "@PatientName",
                    Value = patients_box.Text
                };
                cmd.Parameters.Add(paramdoctorname);

                SqlParameter paramdateofappointments = new SqlParameter()
                {
                    ParameterName = "@DateofAppointment",
                    Value = dateTimePicker1.Value.Date
                };
                cmd.Parameters.Add(paramdateofappointments);

                SqlParameter paramtimeofappointments = new SqlParameter()
                {
                    ParameterName = "@TimeofAppointment",
                    Value = dateTimePicker2.Value.TimeOfDay
                };
                cmd.Parameters.Add(paramtimeofappointments);

                SqlParameter parampatientohone = new SqlParameter()
                {
                    ParameterName = "@PatientsPhone",
                    Value = patients_phone.Text
                };
                cmd.Parameters.Add(parampatientohone);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void appointment_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GetTimeDate(sender, "HH:mm");
        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            GetTimeDate(sender, "HH:mm");
        }
        private void GetTimeDate(object sender, string format)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = format;
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Back)|| (e.KeyCode == Keys.Delete))
            {
                GetTimeDate(sender, " ");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

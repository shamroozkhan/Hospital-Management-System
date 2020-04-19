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
    public partial class patientreg : Form
    {
        public patientreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("CreatePatient", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramname = new SqlParameter()
                {
                    ParameterName = "@Name",
                    Value = name.Text
                };
                cmd.Parameters.Add(paramname);

                SqlParameter paramage = new SqlParameter()
                {
                    ParameterName = "@Age",
                    Value = phone.Text
                };
                cmd.Parameters.Add(paramage);

                SqlParameter paramgender = new SqlParameter()
                {
                    ParameterName = "@Gender",
                    Value = gender.Text
                };
                cmd.Parameters.Add(paramgender);

                SqlParameter paramphone = new SqlParameter()
                {
                    ParameterName = "@Phone",
                    Value = phone.Text
                };
                cmd.Parameters.Add(paramphone);

                //SqlParameter paramNewId = new SqlParameter()
                //{
                //    ParameterName = "@PatientsId",
                //    Value = -1,
                //    Direction = ParameterDirection.Output
                //};
                //cmd.Parameters.Add(paramNewId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientreg_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

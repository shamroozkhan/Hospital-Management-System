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
    public partial class doctorreg : Form
    {
        public doctorreg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doctorreg_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("InsertDoctor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramname = new SqlParameter()
                {
                    ParameterName = "@Name",
                    Value = name.Text
                };
                cmd.Parameters.Add(paramname);

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

                SqlParameter paramcnic = new SqlParameter()
                {
                    ParameterName = "@Cnic",
                    Value = cnic.Text
                };
                cmd.Parameters.Add(paramcnic);

                SqlParameter paramqualification = new SqlParameter()
                {
                    ParameterName = "@Qualification",
                    Value = qualification.Text
                };
                cmd.Parameters.Add(paramqualification);

                SqlParameter paramaddress = new SqlParameter()
                {
                    ParameterName = "@Address",
                    Value = address.Text
                };
                cmd.Parameters.Add(paramaddress);

                SqlParameter paramage = new SqlParameter()
                {
                    ParameterName = "@Age",
                    Value = age.Text
                };
                cmd.Parameters.Add(paramage);

                SqlParameter paramspecification = new SqlParameter()
                {
                    ParameterName = "@Specification",
                    Value = specification.Text
                };
                cmd.Parameters.Add(paramspecification);

                SqlParameter paramdocfees = new SqlParameter()
                {
                    ParameterName = "@DocFees",
                    Value = doc_fees.Text
                };
                cmd.Parameters.Add(paramdocfees);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void doc_fees_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void qualification_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clic(object sender, EventArgs e)
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

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

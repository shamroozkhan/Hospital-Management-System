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
    public partial class appointment_reg : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;


        public appointment_reg()
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

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GetTimeDate(sender, "HH:mm");
        }
        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            GetTimeDate(sender, "HH:mm");
        }
        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                GetTimeDate(sender, " ");
            }
        }
        private void GetTimeDate(object sender, string format)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.CustomFormat = format;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // appointment_reg
            // 
            this.Name = "appointment_reg";
            this.Load += new System.EventHandler(this.appointment_reg_Load);
            this.ResumeLayout(false);

        }

        private void appointment_reg_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class doctors : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;


        public doctors()
        {
            InitializeComponent();
        }
        //int indexRow;

        private void doctors_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Doctorsdata();
            Doctorsdata();
        }

        private DataTable Doctorsdata()
        {
            DataTable dtdoctors = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Doctors", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtdoctors.Load(reader);

                }

            }
                return dtdoctors;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //    indexRow = e.RowIndex;
            //    DataGridViewRow row = dataGridView1.Rows[indexRow];
            //    textBox1.Text = row.Cells[0].Value.ToString();
            //    textBox2.Text = row.Cells[1].Value.ToString();
            //    textBox3.Text = row.Cells[2].Value.ToString();
            //    textBox4.Text = row.Cells[3].Value.ToString();
            //    textBox5.Text = row.Cells[4].Value.ToString();
            //    textBox6.Text = row.Cells[5].Value.ToString();
            //    textBox7.Text = row.Cells[6].Value.ToString();
            //    textBox8.Text = row.Cells[7].Value.ToString();
            //    textBox9.Text = row.Cells[8].Value.ToString();
            //    textBox10.Text = row.Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    DataGridViewRow newRow = dataGridView1.Rows[indexRow];
            //    newRow.Cells[0].Value = textBox1.Text;
            //    newRow.Cells[1].Value = textBox2.Text;
            //    newRow.Cells[2].Value = textBox3.Text;
            //    newRow.Cells[3].Value = textBox4.Text;
            //    newRow.Cells[4].Value = textBox5.Text;
            //    newRow.Cells[5].Value = textBox6.Text;
            //    newRow.Cells[6].Value = textBox7.Text;
            //    newRow.Cells[7].Value = textBox8.Text;
            //    newRow.Cells[8].Value = textBox9.Text;
            //    newRow.Cells[9].Value = textBox10.Text;
        }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

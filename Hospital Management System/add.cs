using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class add : UserControl
    {
        public add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctorreg docreg = new doctorreg();
            docreg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appointments_make appointmentsmake = new appointments_make();
            appointmentsmake.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            patientreg patients_reg = new patientreg();
            patients_reg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bill_generate bill = new bill_generate();
            bill.Show();
        }
    }
}

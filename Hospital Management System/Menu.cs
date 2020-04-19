using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            side_panel.Height = button4.Height;
            side_panel.Top = button4.Top;
            add1.BringToFront();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            side_panel.Height = button1.Height;
            side_panel.Top = button1.Top;
            doctors2.BringToFront();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            side_panel.Height = button2.Height;
            side_panel.Top = button2.Top;
            appointments3.BringToFront();
        }

        private void side_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            side_panel.Height = button4.Height;
            side_panel.Top = button4.Top;
            add1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            side_panel.Height = button4.Height;
            side_panel.Top = button4.Top;
            patients1.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            side_panel.Height = button4.Height;
            side_panel.Top = button4.Top;
            bill1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //this.Close();
        }

        private void bill1_Load(object sender, EventArgs e)
        {

        }

        private void add1_Load(object sender, EventArgs e)
        {

        }
    }
}

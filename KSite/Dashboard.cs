using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSite
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBox3.Parent = panel1;
            pictureBox3.BackColor = Color.Transparent;
            button1.BackColor = Color.DarkGray;
            button2.BackColor = Color.DarkGray;
            button3.BackColor = Color.DarkGray;
            button4.BackColor = Color.DarkGray;
            button5.BackColor = Color.DarkGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.Show();
            home1.BringToFront();
            store1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            store1.Show();
            store1.BringToFront();
            home1.Hide();
        }
    }
}

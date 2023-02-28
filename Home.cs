using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Emsi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestionlivre l = new gestionlivre();
            this.Hide();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestionperiodique p = new gestionperiodique();
            this.Hide();
            p.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestionCDs c = new gestionCDs();
            this.Hide();
            c.Show();
        }
    }
}

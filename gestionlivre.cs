using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Library_Emsi
{
    public partial class gestionlivre : Form
    {
        int currRowIndex;
        public gestionlivre()
        {

            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void gestionlivre_Load_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            currRowIndex = Convert.ToInt32(row.Cells[0].Value);
            textBox1.Text = row.Cells[3].Value.ToString();
            textBox2.Text = row.Cells[4].Value.ToString();
            textBox3.Text = row.Cells[5].Value.ToString();
            dateTimePicker1.Text = Convert.ToString(row.Cells[1].Value);

            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                DialogResult dialogClose = MessageBox.Show("Veuillez Remplier Tous Les Champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Livre L = new Livre(dateTimePicker1.Text, textBox1.Text, textBox2.Text, textBox3.Text);

                dataGridView1.Rows.Add("", textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gestionperiodique p = new gestionperiodique();
            this.Hide();
            p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gestionlivre l = new gestionlivre();
            this.Hide();
            panel1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gestionCDs c = new gestionCDs();
            this.Hide();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            DialogResult dialogDelete = MessageBox.Show("voulez-vous vraiment supprimer ce Livre", "Supprimer un Livre", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogDelete == DialogResult.OK)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                button2.Enabled = false;
                button3.Enabled = false;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogUpdate = MessageBox.Show("voulez-vous vraiment modifier les informations sur ce livre ", "Modifier un livre", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogUpdate == DialogResult.OK)
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    DialogResult dialogClose = MessageBox.Show("Veuillez renseigner tous les champs", "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); 
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

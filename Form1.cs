namespace Library_Emsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (textBox1.Text == "saad" && textBox2.Text == "admin")
            {
                Home h = new Home();
                this.Hide();
                h.Show();
            }
            else
                    MessageBox.Show("Login/mot de passe est incorrect");


            }
        }
}
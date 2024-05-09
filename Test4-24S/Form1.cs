using static System.Net.Mime.MediaTypeNames;

namespace Test4_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string t1 = textBox2.Text;
            string t2 = textBox3.Text;
            string t3 = textBox4.Text;
            string t4 = textBox5.Text;
            textBox2.Text = text;
                textBox3.Text = t1;
            textBox4.Text = t2;
            textBox5.Text = t3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rem = "";
            textBox1.Text = rem;
            textBox2.Text = rem;
            textBox3.Text = rem;
            textBox4.Text = rem;
            textBox5.Text = rem;

        }
    }
}

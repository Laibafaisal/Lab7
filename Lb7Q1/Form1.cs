namespace Lb7Q1
{
    public partial class Form1 : Form
    {
        double x, y, res;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            res = x - y;
            textBox3.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            res = x * y;
            textBox3.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            res = x / y;
            textBox3.Text = res.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            res = x + y;
            textBox3.Text = res.ToString();
        }
    }
}
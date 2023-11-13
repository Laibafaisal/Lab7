namespace Lab7Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(textBox1.Text);
            double res = ((x - 32) * 5) / 9;
            textBox2.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
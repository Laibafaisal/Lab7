namespace Lab7Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 1;
            int x = int.Parse(textBox1.Text);
            for (int i = 1; i <= x; i++)
            {
                res = res * i;
            }
            textBox2.Text = res.ToString();
        }
    }
}
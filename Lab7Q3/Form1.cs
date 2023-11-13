namespace Lab7Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Hide();
            label6.Hide();
            label8.Hide();
            label10.Hide();
            label12.Hide();
            label14.Hide();
            label16.Hide();
            label18.Hide();
            label20.Hide();
            label22.Hide();
        }

        private int calc(Label label)
        {
            int x = int.Parse(label.Text);
            return x * x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = calc(label3).ToString();
            label4.Visible = true;
            label6.Text = calc(label5).ToString();
            label6.Visible = true;
            label8.Text = calc(label7).ToString();
            label8.Visible = true;
            label10.Text = calc(label9).ToString();
            label10.Visible = true;
            label12.Text = calc(label11).ToString();
            label12.Visible = true;
            label14.Text = calc(label13).ToString();
            label14.Visible = true;
            label16.Text = calc(label15).ToString();
            label16.Visible = true;
            label18.Text = calc(label17).ToString();
            label18.Visible = true;
            label20.Text = calc(label19).ToString();
            label20.Visible = true;
            label22.Text = calc(label21).ToString();
            label22.Visible = true;
        }
    }
}
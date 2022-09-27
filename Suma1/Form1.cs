namespace Suma1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int suma, a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            suma = a + b;
            textBox3.Text = suma.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
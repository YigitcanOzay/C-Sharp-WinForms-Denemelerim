namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("naber");
            MessageBox.Show("Merhaba Dünya");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = label4.Text;
            //textBox3.Text = label8.Text;
            //textBox2.Text = label7.Text;
            label4.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label8.Text = textBox3.Text;

        }
    }
}
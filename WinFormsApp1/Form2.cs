using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hakkari");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("bakkal");
            listBox1.Items.Add("kasiyer");
            listBox1.Items.Add("senarist");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add((string)textBox2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

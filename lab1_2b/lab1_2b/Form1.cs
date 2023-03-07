using System;
using System.Windows.Forms;
namespace lab1_2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double x3 = Convert.ToDouble(textBox3.Text);
            double y1 = Convert.ToDouble(textBox4.Text);
            double y2 = Convert.ToDouble(textBox5.Text);
            double y3 = Convert.ToDouble(textBox6.Text);
            double Evklid = Math.Sqrt((Math.Pow(x1 - y1, 2)) + (Math.Pow(x2 - y2, 2)) + (Math.Pow(x3 - y3, 2)));
            double City = Math.Abs(x1 - y1) + Math.Abs(x2 - y2) + Math.Abs(x3 - y3);
            double Cheb = Math.Max(Math.Max(x1 - y1, x2 - y2), x3 - y3);
            label11.Text = Convert.ToString(Evklid);
            label12.Text = Convert.ToString(City);
            label13.Text = Convert.ToString(Cheb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
        }
    }
}

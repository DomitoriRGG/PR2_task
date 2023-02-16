using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox2.Text);
            textBox1.Text += Environment.NewLine +
                "X = " + x.ToString();
            double y = double.Parse(textBox3.Text);
            textBox1.Text += Environment.NewLine +
                "Y = " + y.ToString();
            double z = double.Parse(textBox4.Text);
            textBox1.Text += Environment.NewLine +
                "Z = " + z.ToString();

            double a = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), (x + y));
            double b = Math.Atan(x) + Math.Atan(z);
            double c = Math.Pow(Math.Pow(x, 6) + Math.Log(Math.Pow(1, 2)) * y, 1/3);

            double u = a / b + c;
            textBox1.Text += Environment.NewLine +
                "Результат: φ = " + u.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

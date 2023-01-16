using System;
using System.Windows.Forms;

namespace Лаба_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_MouseMove(object sender, MouseEventArgs a)
        {
            textBox1.Text = a.X.ToString();
            textBox2.Text = a.Y.ToString();
        }

        private void Form2_DoubleClick(object sender, EventArgs z)
        {
           double f = Convert.ToDouble(textBox1.Text);
            double e = Convert.ToDouble(textBox2.Text);
            double w = Convert.ToDouble(textBox3.Text);
            double y = Convert.ToDouble(textBox4.Text);

            double U = Math.Sqrt(Math.Abs(f - e / w) + Math.Abs(Math.Pow(Math.Sin(e / w), 2) + Math.Cos(y)));
            Text = string.Format("Результат: {0}", U);

        }

        private void button1_Click(object sender, EventArgs z)
        {
            MessageBox.Show("Прив)0)");
        }
    }
}

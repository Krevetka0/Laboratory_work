using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z = 0;
            if (radioButton1.Checked == true)
            { 
                double X = Convert.ToDouble(textBoxX.Text);
                double Y = Convert.ToDouble(textBoxY.Text);
                z = -Y / 2 + Math.Pow(Y, 2)/6 - Math.Pow(X, 3)/24 + Math.Pow(Y, 4)/120;
                textBoxZ.Text = Math.Round(z, 4).ToString();
            }
            if (radioButton2.Checked == true) 
            {
                double a = Convert.ToDouble(textBoxa.Text);
                double b = Convert.ToDouble(textBoxb.Text);
                double c = Convert.ToDouble(textBoxc.Text);
                double N = Convert.ToDouble(comboBoxN.Text);
                double R = Convert.ToDouble(comboBoxR.Text);

                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= R; j++)
                    {
                        z += (a * i + b * j) / c * Math.Pow(i, j);
                    }
                }
                textBoxZ.Text = Math.Round(z, 4).ToString();
            }
        }
    }
}

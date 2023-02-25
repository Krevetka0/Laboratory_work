using System;
using System.Windows.Forms;

namespace _3_практическая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ToolStripMenuItem currentCheckedEquation;
        private void Calculate_menu_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, x, y, z;
                try
                {
                    a = double.Parse(aComboBox.Text);
                    aContextComboBox.Text = a.ToString();
                }
                catch { a = double.Parse(aContextComboBox.Text); }
                try
                {
                    b = double.Parse(bComboBox.Text);
                    bContextComboBox.Text = b.ToString();
                }
                catch { b = double.Parse(bContextComboBox.Text); }
                try
                {
                    x = double.Parse(xTextBox.Text);
                    xContextTextBox.Text = x.ToString();
                }
                catch { x = double.Parse(xContextTextBox.Text); }
                try
                {
                    y = double.Parse(yTextBox.Text);
                    yContextTextBox.Text = y.ToString();
                }
                catch { y = double.Parse(yContextTextBox.Text); }
                try
                {
                    z = double.Parse(zTextBox.Text);
                    zContextTextBox.Text = z.ToString();
                }
                catch { z = double.Parse(zContextTextBox.Text); }

                resultTextBox.Text = Math.Round(a * x / b + b * y / x + Math.Sin(z), 4).ToString();
            }
            catch { MessageBox.Show("Убедитесь, что все данные введены корректно"); }
        }

        private void Calculate_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, x, y, z;

                try
                {
                    a = double.Parse(aContextComboBox.Text);
                    aComboBox.Text = a.ToString();
                }
                catch { a = double.Parse(aComboBox.Text); }
                try
                {
                    b = double.Parse(bContextComboBox.Text);
                    bComboBox.Text = b.ToString();
                }
                catch { b = double.Parse(bComboBox.Text); }
                try
                {
                    x = double.Parse(xContextTextBox.Text);
                    xTextBox.Text = x.ToString();
                }
                catch { x = double.Parse(xTextBox.Text); }
                try
                {
                    y = double.Parse(yContextTextBox.Text);
                    yTextBox.Text = y.ToString();
                }
                catch { y = double.Parse(yTextBox.Text); }
                try
                {
                    z = double.Parse(zContextTextBox.Text);
                    zTextBox.Text = z.ToString();
                }
                catch { z = double.Parse(zTextBox.Text); }

                resultTextBox.Text = Math.Round(a * x / b + b * y / x + Math.Sin(z), 4).ToString();
            }
            catch { MessageBox.Show("Убедитесь, что все данные введены корректно"); }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
             Text = string.Format($"Координаты курсора мыши: {e.X}; {e.Y}");
            if (currentCheckedEquation == ThirdUrav)
                ResulttoolStripStatusLabel3.Text = (Math.Sqrt(e.X/e.Y) +Math.Pow(e.Y,2)).ToString();
            else if (currentCheckedEquation == SecondUrav)
                ResulttoolStripStatusLabel3.Text = Math.Sqrt(Math.Pow(e.X, 4)).ToString();
            else if (currentCheckedEquation == FirstUrav)
                ResulttoolStripStatusLabel3.Text = Math.Pow(e.Y, 3).ToString();
            else
                ResulttoolStripStatusLabel3.Text = "Уравнение не выбрано";
        }

        private void FirstUrav_Click(object sender, EventArgs e)
        {
            currentCheckedEquation = FirstUrav;
        }

        private void SecondUrav_Click(object sender, EventArgs e)
        {
            currentCheckedEquation = SecondUrav;
        }

        private void ThirdUrav_Click(object sender, EventArgs e)
        {
            currentCheckedEquation = ThirdUrav;
        }
    }
}

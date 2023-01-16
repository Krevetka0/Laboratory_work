using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Вывод в заголовок экрана
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            //Сумма координат
            textBox1.Text = (e.X + e.Y).ToString();
        }
    }
}

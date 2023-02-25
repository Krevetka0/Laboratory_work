using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Лаба_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_butt_Click(object sender, RoutedEventArgs e)
        {
            double n = Convert.ToDouble(ComboN.Text);
            double k = Convert.ToDouble(ComboK.Text);
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double f = Convert.ToDouble(txtF.Text);
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    res += Math.Sin(x) * Math.Pow(x, i) + Math.Pow(f, j) * Math.Pow(y, j) / (i * j);
                }
            }
            this.Title = "Ответ: " + Math.Round(res, 2).ToString("F");
        }
    }
}

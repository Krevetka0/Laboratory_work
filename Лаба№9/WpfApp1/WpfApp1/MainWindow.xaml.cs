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

namespace WpfApp1
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

        private void btnChangeColor_Click(object sender, RoutedEventArgs e)
        {
            byte a = Convert.ToByte(aValueSrc.Value),
                r = Convert.ToByte(rValueSrc.Value),
                g = Convert.ToByte(gValueSrc.Value),
                b = Convert.ToByte(bValueSrc.Value);
            rct.Fill = new SolidColorBrush(Color.FromArgb(a, r, g, b));
            txtDestination.Foreground=new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }
    }
}

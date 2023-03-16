using System.Windows;
using LogicTier;

namespace PresentationTier
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Касса logicTier = new Касса();
            this.DataContext = logicTier;
            InitializeComponent();
        }
    }
}

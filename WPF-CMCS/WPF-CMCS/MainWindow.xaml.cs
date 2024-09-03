using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_CMCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ApplyDarkMode()
        {
            this.Background = new SolidColorBrush(Color.FromRgb(18, 18, 18));
            
        }
        private void ApplyLightMode()
        {
            this.Background = new SolidColorBrush(Colors.White);
           
        }

    }
}
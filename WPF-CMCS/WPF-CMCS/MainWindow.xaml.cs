using System.Windows;

namespace WPF_CMCS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenClaimWindow_Click(object sender, RoutedEventArgs e)
        {
            var claimWindow = new ClaimWindow();
            claimWindow.Show();
        }

        private void OpenManageClaimsWindow_Click(object sender, RoutedEventArgs e)
        {
            var manageClaimsWindow = new Window();
            manageClaimsWindow.Content = new CoordinatorManagerView();
            manageClaimsWindow.Title = "Manage Claims";
            manageClaimsWindow.Show();
        }

        private void OpenHRWindow_Click(object sender, RoutedEventArgs e)
        {
            var hrWindow = new Window();
            hrWindow.Content = new HRView();
            hrWindow.Title = "HR View";
            hrWindow.Show();
        }
    }
}
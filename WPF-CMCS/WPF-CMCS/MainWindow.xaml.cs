using System;
using System.Windows;

namespace WPF_CMCS
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClaimWindow claimWindow = new ClaimWindow();
                claimWindow.Owner = this;
                claimWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                claimWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Claim Window: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       

        private void UserManagementButton_Click(object sender, RoutedEventArgs e)
        {
            new UserManagementWindow().Show();
        }

        private void ApprovalProcessButton_Click(object sender, RoutedEventArgs e)
        {
            new ApprovalProcessWindow().Show();
        }
    }
}
using System;
using System.Linq;
using System.Windows;

namespace WPF_CMCS
{
    public partial class ApprovalProcessWindow : Window
    {
        public ApprovalProcessWindow()
        {
            InitializeComponent();
            LoadPendingClaims();
        }

        private void LoadPendingClaims()
        {
            var pendingClaims = ClaimData.Claims.Where(c => c.Status == "Pending").ToList();
            PendingClaimsListView.ItemsSource = pendingClaims;
        }

        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedClaim = PendingClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Approved";
                LoadPendingClaims();
                MessageBox.Show("Claim approved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedClaim = PendingClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Rejected";
                LoadPendingClaims();
                MessageBox.Show("Claim rejected successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a claim to reject.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RequestInfoButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedClaim = PendingClaimsListView.SelectedItem as Claim;
            if (selectedClaim != null)
            {
                // TODO: Implement request more information logic
                MessageBox.Show("Additional information requested for the selected claim.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a claim to request more information.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
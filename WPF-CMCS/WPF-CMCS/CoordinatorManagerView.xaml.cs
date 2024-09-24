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
using System.Windows.Shapes;
using System.Linq;


namespace WPF_CMCS
{
    public partial class CoordinatorManagerView : UserControl
    {
        public CoordinatorManagerView()
        {
            InitializeComponent();
            LoadPendingClaims();
        }

        private void LoadPendingClaims()
        {
            var pendingClaims = ClaimData.Claims.Where(c => c.Status == "Pending").ToList();
            PendingClaimsListView.ItemsSource = pendingClaims;
        }

        private void VerifyClaims_Click(object sender, RoutedEventArgs e)
        {
            foreach (Claim claim in PendingClaimsListView.Items)
            {
                if (VerifyClaim(claim))
                {
                    claim.Status = "Verified";
                }
                else
                {
                    claim.Status = "Rejected";
                }
            }
            LoadPendingClaims();
            MessageBox.Show("Claim verification completed.", "Verification", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private bool VerifyClaim(Claim claim)
        {
            // Implement your verification logic here
            // For example, check if hours are within acceptable range, rate is correct, etc.
            return claim.Hours <= 40 && claim.Rate >= 20 && claim.Rate <= 100;
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
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

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
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
    }
}

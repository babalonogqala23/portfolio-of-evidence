using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPF_CMCS
{
    public partial class HRView : UserControl
    {
        public HRView()
        {
            InitializeComponent();
            LoadApprovedClaims();
        }

        private void LoadApprovedClaims()
        {
            var approvedClaims = ClaimData.Claims.Where(c => c.Status == "Approved").ToList();
            ApprovedClaimsListView.ItemsSource = approvedClaims;
        }

        private void GenerateInvoices_Click(object sender, RoutedEventArgs e)
        {
            var invoices = ClaimData.Claims
                .Where(c => c.Status == "Approved")
                .GroupBy(c => c.LecturerName)
                .Select(g => new
                {
                    LecturerName = g.Key,
                    TotalPayment = g.Sum(c => c.TotalPayment)
                })
                .ToList();

            InvoicesListView.ItemsSource = invoices;
            MessageBox.Show("Invoices generated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UpdateLecturerData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Lecturer data update functionality would be implemented here.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
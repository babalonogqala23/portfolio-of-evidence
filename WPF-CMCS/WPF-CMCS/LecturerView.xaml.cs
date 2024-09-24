using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_CMCS
{
    public partial class LecturerView : UserControl
    {
        public LecturerView()
        {
            InitializeComponent();
            ClaimsListView.ItemsSource = ClaimData.Claims;
        }
        private void CalculatePayment_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(HoursWorkedTextBox.Text, out double hours) &&
                double.TryParse(HourlyRateTextBox.Text, out double rate))
            {
                double payment = hours * rate;
                PaymentResultTextBlock.Text = $"Total Payment: ${payment:F2}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for hours worked and hourly rate.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInput())
            {
                var newClaim = new Claim
                {
                    Id = ClaimData.Claims.Count + 1,
                    LecturerName = LecturerNameTextBox.Text,
                    Hours = double.Parse(HoursWorkedTextBox.Text),
                    Rate = double.Parse(HourlyRateTextBox.Text),
                    TotalPayment = double.Parse(HoursWorkedTextBox.Text) * double.Parse(HourlyRateTextBox.Text),
                    Status = "Pending"
                };

                ClaimData.Claims.Add(newClaim);
                MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearForm();
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(LecturerNameTextBox.Text))
            {
                MessageBox.Show("Please enter your name.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!double.TryParse(HoursWorkedTextBox.Text, out double hours) || hours <= 0)
            {
                MessageBox.Show("Please enter a valid number of hours worked.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!double.TryParse(HourlyRateTextBox.Text, out double rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid hourly rate.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            LecturerNameTextBox.Clear();
            HoursWorkedTextBox.Clear();
            HourlyRateTextBox.Clear();
            PaymentResultTextBlock.Text = string.Empty;
        }
    }
}
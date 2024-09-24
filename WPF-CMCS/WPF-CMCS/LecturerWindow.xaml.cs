using System;
using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace WPF_CMCS
{
    public partial class LecturerWindow : Window
    {
        private string uploadedFilePath;

        public LecturerWindow()
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

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                uploadedFilePath = openFileDialog.FileName;
                DocumentPathTextBox.Text = Path.GetFileName(uploadedFilePath);
            }
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
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

                if (!string.IsNullOrEmpty(uploadedFilePath))
                {
                    string destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }
                    string fileName = $"Claim_{newClaim.Id}_{Path.GetFileName(uploadedFilePath)}";
                    File.Copy(uploadedFilePath, Path.Combine(destinationPath, fileName), true);
                    newClaim.DocumentPath = fileName;
                }

                ClaimData.Claims.Add(newClaim);
                MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearForm();
                ClaimsListView.Items.Refresh();
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
            DocumentPathTextBox.Clear();
            uploadedFilePath = null;
        }
    }
}
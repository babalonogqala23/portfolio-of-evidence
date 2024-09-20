using System;
using System.Windows;
using Microsoft.Win32;
using System.IO;

namespace WPF_CMCS
{

    public partial class ClaimWindow : Window

    {

        private string? uploadedFilePath;


        public ClaimWindow()
        {
            InitializeComponent();
            LoadClaimTypes();
            ClaimsListView.ItemsSource = ClaimData.Claims;
        }

        private void LoadClaimTypes()
        {
            ClaimTypeComboBox.Items.Add("Regular Hours");
            ClaimTypeComboBox.Items.Add("Overtime");
            ClaimTypeComboBox.Items.Add("Special Project");
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ClaimTypeComboBox.SelectedItem == null)
                {
                    throw new ArgumentException("Please select a claim type.");
                }

                if (!double.TryParse(HoursTextBox.Text, out double hours) || hours <= 0)
                {
                    throw new ArgumentException("Please enter a valid number of hours worked.");
                }

                if (!double.TryParse(RateTextBox.Text, out double rate) || rate <= 0)
                {
                    throw new ArgumentException("Please enter a valid hourly rate.");
                }

                var claimType = ClaimTypeComboBox.SelectedItem as string;
                var notes = NotesTextBox.Text;

                var newClaim = new Claim
                {
                    Id = ClaimData.Claims.Count + 1,
                    Type = claimType,
                    Hours = hours,
                    Rate = rate,
                    Status = "Pending"
                };

                ClaimData.Claims.Add(newClaim);

                if (!string.IsNullOrEmpty(uploadedFilePath))
                {
                    // TODO: Save the uploaded file to a secure location and associate it with the claim
                    var destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads", $"Claim_{newClaim.Id}_{Path.GetFileName(uploadedFilePath)}");
                    File.Copy(uploadedFilePath, destinationPath, true);
                }

                MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                // TODO: Log the exception for further investigation
            }
        }

       

       

        private void UploadDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Document files (*.pdf;*.docx;*.xlsx)|*.pdf;*.docx;*.xlsx|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                uploadedFilePath = openFileDialog.FileName;
                UploadedFileNameLabel.Content = Path.GetFileName(uploadedFilePath);
            }

        }

        

        private void ClearForm()
        {
            ClaimTypeComboBox.SelectedIndex = -1;
            HoursTextBox.Clear();
            RateTextBox.Clear();
            NotesTextBox.Clear();
            uploadedFilePath = null;
            UploadedFileNameLabel.Content = "";
        }
    }

    public class Claim
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public double Hours { get; set; }
        public double Rate { get; set; }
        public string? Status { get; set; }
    }
}
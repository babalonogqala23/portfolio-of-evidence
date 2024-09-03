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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateRecentClaims();
        }
   
        private void DarkModeToggle_Checked(object sender, RoutedEventArgs e)
        {
            ApplyDarkMode();
        }

        private void DarkModeToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            ApplyLightMode();
        }
        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the upload functionality here
            MessageBox.Show("Upload Button Clicked");
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the submit functionality here
            MessageBox.Show("Submit Claim Button Clicked");
        }


        private void ApplyDarkMode()
        {
            this.Background = new SolidColorBrush(Color.FromRgb(18, 18, 18));
            // Apply dark mode styles to other controls
        }

        private void ApplyLightMode()
        {
            this.Background = new SolidColorBrush(Colors.White);
            // Apply light mode styles to other controls
        }
        private void PopulateRecentClaims()
        {
            // Example data population logic
            var claims = new List<Claim>
    {
        new Claim { ClaimNumber = "12345", Status = "Pending", StatusColor = Brushes.Orange },
        new Claim { ClaimNumber = "67890", Status = "Approved", StatusColor = Brushes.Green }
    };

            RecentClaimsListBox.ItemsSource = claims;
        }

        public class Claim
        {
            public string ClaimNumber { get; set; }
            public string Status { get; set; }
            public Brush StatusColor { get; set; }
        }


    }
}
        
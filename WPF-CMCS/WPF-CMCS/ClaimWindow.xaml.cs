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

namespace WPF_CMCS
{
    /// <summary>
    /// Interaction logic for ClaimWindow.xaml
    /// </summary>
    public partial class ClaimWindow : Window
    {
        public ClaimWindow()
        {
            InitializeComponent();
            // TODO: Load claim types into ClaimTypeComboBox
            // TODO: Load user's claims into ClaimsListView
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement claim submission logic
        }
    }
}

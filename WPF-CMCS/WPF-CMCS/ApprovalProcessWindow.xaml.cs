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
    /// Interaction logic for ApprovalProcessWindow.xaml
    /// </summary>
   
        public partial class ApprovalProcessWindow : Window
        {
            public ApprovalProcessWindow()
            {
                InitializeComponent();
                // TODO: Load pending claims into PendingClaimsListView
            }

            private void ApproveButton_Click(object sender, RoutedEventArgs e)
            {
                // TODO: Implement approve claim logic
            }

            private void RejectButton_Click(object sender, RoutedEventArgs e)
            {
                // TODO: Implement reject claim logic
            }

            private void RequestInfoButton_Click(object sender, RoutedEventArgs e)
            {
                // TODO: Implement request more information logic
            }
        }
    }


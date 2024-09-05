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
    /// Interaction logic for UserManagementWindow.xaml
    /// </summary>
    public partial class UserManagementWindow : Window
    {
        public UserManagementWindow()
        {
            InitializeComponent();
            // TODO: Load user types into UserTypeComboBox
            // TODO: Load users into UsersListView
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement add user logic
        }

        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement update user logic
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Implement delete user logic
        }
    }
}

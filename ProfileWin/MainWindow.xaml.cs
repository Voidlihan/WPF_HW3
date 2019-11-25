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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProfileWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
            using (var _context = new Context())
            {
                Service _profileService = new Service(_context);
                User currentCustomer = _profileService.GetUser((Application.Current as App).currentUser);
                WindowProfile userWindowProfile = new WindowProfile();
                userWindowProfile.textBoxLoginEdit.Text = currentCustomer.Login;
                userWindowProfile.textBoxPasswordEdit.Text = currentCustomer.Password;
                userWindowProfile.Show();                
            }
        }

        private void SignUpButtonClick(object sender, RoutedEventArgs e)
        {
            User customer = new User
            {
                Login = loginInput.Text,
                Password = passwordInput.Text
            };

            using (var context = new Context())
            {
                Service profileService = new Service(context);
                profileService.Add(customer);
            }
        }
    }
}

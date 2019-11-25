using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProfileWin
{
    /// <summary>
    /// Interaction logic for WindowProfile.xaml
    /// </summary>
    public partial class WindowProfile : Window
    {
        static Context context = new Context();
        static Service profileService = new Service(context);
        public WindowProfile()
        {
            InitializeComponent();
        }
        private void saveChangesButtonClick(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                Login = textBoxLoginEdit.Text,
                Password = textBoxPasswordEdit.Text
            };
            profileService.UpdateProfile(user);
        }

        private void downloadImageClick(object sender, RoutedEventArgs e)
        {
            ImgUrlWindow imageUrlWindow = new ImgUrlWindow();            
            imageUrlWindow.Show();
        }
    }
}

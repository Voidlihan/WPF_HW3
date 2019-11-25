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
    /// Interaction logic for ImgUrlWindow.xaml
    /// </summary>
    public partial class ImgUrlWindow : Window
    {
        public ImgUrlWindow()
        {
            InitializeComponent();
        }

        private void LoadClick(object sender, RoutedEventArgs e)
        {
            using (var context = new Context())
            {
                Service profileService = new Service(context);
                profileService.UpdateImage(imageUrl.Text);    
            }
            
            MessageBox.Show("Фотография успешно загружена");
            
            this.Close();

        }
    }
}

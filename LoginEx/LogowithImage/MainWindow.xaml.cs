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

namespace LogowithImage
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

        private void Yamaha_Click(object sender, RoutedEventArgs e)
        {
            if (Image.Visibility == Visibility.Visible)
            {
                Image.Visibility = Visibility.Collapsed;
            }
            else
            {
                Image.Visibility = Visibility.Visible;
                BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/LogowithImage;component/Resources/YB.jpg", UriKind.Absolute));
                Image.Source = image;
            }

        }

        private void Honda_Click(object sender, RoutedEventArgs e)
        {
            if (Image.Visibility == Visibility.Visible)
            {
                Image.Visibility = Visibility.Collapsed;
            }
            else
            {
                Image.Visibility = Visibility.Visible;
                BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/LogowithImage;component/Resources/HB2.jpg", UriKind.Absolute));
                Image.Source = image;
            }
        }
        

        private void Bajaj_Click(object sender, RoutedEventArgs e)
        {
            if (Image.Visibility == Visibility.Visible)
            {
                Image.Visibility = Visibility.Collapsed;
            }
            else
            {
                Image.Visibility = Visibility.Visible;
                BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/LogowithImage;component/Resources/BB1.jpg", UriKind.Absolute));
                Image.Source = image;
            }
        }
    }
}

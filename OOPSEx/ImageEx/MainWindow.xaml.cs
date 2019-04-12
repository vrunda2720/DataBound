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

namespace ImageEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = this;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if(I1.Visibility == Visibility.Visible)
            {
                I1.Visibility = Visibility.Collapsed;
            }
            else
            {
                I1.Visibility = Visibility.Visible;
                BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/ImageEx;component/Resources/car.jpg", UriKind.Absolute));
                I1.Source = image;
            }

           
           
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (I1.Visibility == Visibility.Visible)
            {
                I1.Visibility = Visibility.Collapsed;
            }
            else
            {
                I1.Visibility = Visibility.Visible;
                BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/ImageEx;component/Resources/bike.jpg", UriKind.Absolute));
                I1.Source = image;
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (I1.Visibility == Visibility.Visible)
            {
                I1.Visibility = Visibility.Collapsed;
            }
            else
            {
                I1.Visibility = Visibility.Visible;
                BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/ImageEx;component/Resources/train.jpg", UriKind.Absolute));
                I1.Source = image;
            }
        }
    }
}

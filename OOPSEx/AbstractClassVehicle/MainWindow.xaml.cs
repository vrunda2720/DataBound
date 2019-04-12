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

namespace AbstractClassVehicle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CAR carObject { get; set; }

        public BIKE bikeObject { get; set; }

        public MainWindow()
        {
            carObject = new CAR();
            bikeObject = new BIKE();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(carObject.Speed().ToString());
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(carObject.Wheels().ToString());

        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(carObject.Name().ToString());

        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(bikeObject.Speed().ToString());

        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(bikeObject.Wheels().ToString());

        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(bikeObject.Name().ToString());

        }
    }
}

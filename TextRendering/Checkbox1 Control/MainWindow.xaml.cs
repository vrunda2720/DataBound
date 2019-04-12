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

namespace Checkbox1_Control
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

        private void cbAllfeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newval = (cbAllfeatures.IsChecked == true);
            cbfeatureABC.IsChecked = newval;
            cbfeatureXYZ.IsChecked = newval;
            cbfeatureWWW.IsChecked = newval;


        }

        private void cbfeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllfeatures.IsChecked = null;
            if ((cbfeatureABC.IsChecked == true) && (cbfeatureXYZ.IsChecked == true) && (cbfeatureWWW.IsChecked == true))
                cbAllfeatures.IsChecked = true;
            if ((cbfeatureABC.IsChecked == false) && (cbfeatureXYZ.IsChecked == false) && (cbfeatureWWW.IsChecked == false))
                cbAllfeatures.IsChecked = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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

namespace Getpagewithphonenumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string N1;
        public string P1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            N1 = null;
            P1 = null;

            N1 = Name2.Text;
            P1 = Phone2.Text;

            //MessageBox.Show(N1 + P1);
            string text = N1 + "," + P1;

            if (File.Exists(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt"))
            {
                MessageBox.Show("Already exist");

            }
            
            else
            {
                System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt", text);
            }
        }
        private void Getpage1_Click(object sender, RoutedEventArgs e)
        {
            S1.Visibility = Visibility.Collapsed;
            S2.Visibility = Visibility.Visible;
        }

        private void Getphone_Click(object sender, RoutedEventArgs e)
        {
            // Phone3.Text = File.ReadAllText(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt");
            string read = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt");


            string[] values = read.Split(',');

            N1 = values[0].ToString();
            P1 = values[1].ToString();

            Phone3.Text = P1;

        }

    private void Addpage2_Click(object sender, RoutedEventArgs e)
        {
            S2.Visibility = Visibility.Collapsed;
            S1.Visibility = Visibility.Visible;
        }

       
    }
}

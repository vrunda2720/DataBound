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

namespace LoginEx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string N1;
        public string P1;
        private string text;
        string read;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            N1 = null;
            P1 = null;

            N1 = Name2.Text;
            P1 = Password2.Password;

            //MessageBox.Show(N1 + P1);
            string text = N1 + "," + P1;


            //System.IO.File.Exists(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt", text);
            if (File.Exists(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt"))
            {
                MessageBox.Show("Already exist");
                
            }
            else
            {
                System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt", text);
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt"))
            {
                MessageBox.Show("Wrong Username");
                return;
            }
            else
            {


                string read = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\" + Name2.Text + ".txt");

  
                string[] values = read.Split(',');

                N1 = values[0].ToString();
                P1 = values[1].ToString();
              
                if (Password2.Password == P1)
                {
                    S1.Visibility = Visibility.Collapsed;
                    S2.Visibility = Visibility.Visible;
                    HiText.Text = "Hi " + Name2.Text;

                }
                else
                {
                    MessageBox.Show("Wrong credentials");
                }

            }
        }
    }
}

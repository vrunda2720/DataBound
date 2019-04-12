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

namespace ContactFormSave
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = null;
            string address = null;
            string phone = null;
            string dob = null;
            string gender = null;
            string language = null;

            name = txtname.Text;
            address = txtadr.Text;
            phone = txtphone.Text;
            dob = txtbirth.Text;
            if(r1.IsChecked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if(L1.IsChecked == true)
            {
                language = language + "Hindi";
            }
            if(L2.IsChecked == true)
            {
                language = language + "/" + "Gujarati";
            }
            if(L3.IsChecked == true)
            {
                language = language + "/" + "English";
            }

            MessageBox.Show(name + address + phone + dob + gender + language);
            string text = name +"," + address + "," + phone + "," + dob + "," + gender + "," + language ;

            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           string read = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");

            string[] values = read.Split(',');

            string name = values[0].ToString();
            string address = values[1].ToString();
            string phone = values[2].ToString();
            string dob = values[3].ToString();
            string gender = values[4].ToString();
            string language = values[5].ToString();

            txtname.Text = name;
            txtadr.Text = address;
            txtbirth.Text = dob;
            txtphone.Text = phone;
            //var button = sender as RadioButton;

            if (gender=="Male")
            {
                r1.IsChecked = true;
            }
            else
            {
                r2.IsChecked = true;
            }

            if(language.Contains("Hindi"))
            {
                L1.IsChecked = true;
            }
            if(language.Contains("Gujarati"))
            {
                L2.IsChecked = true;
            }
            if(language.Contains("English"))
            {
                L3.IsChecked = true;
            }
          //  if
            //MessageBox.Show(read);

        }
    }
}

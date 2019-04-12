using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace validationex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool iseverythingTrue = false;
       
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Validbtn_Click(object sender, RoutedEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(boxname.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name is not valid");
                iseverythingTrue = true;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(boxage.Text, "^0*([1-9]|[1-8][0-9]|9[0-9]|1[01][0-9]|120)$"))
            {
                MessageBox.Show("Age is not valid");
                iseverythingTrue = true;
            }

            var a = Picker.SelectedDate;

            DateTime dt;
            Boolean isvaliddate = DateTime.TryParse(a.ToString(), out dt);

            if(!isvaliddate)
            {
                MessageBox.Show("Not a valid date");
                iseverythingTrue = true;

            }

            if (!Regex.IsMatch(boxNospecial.Text, @"^[\sa-zA-Z0-9]*$"))
            {
                MessageBox.Show("Special characters are not allowed.");
                iseverythingTrue = true;

            }

            if (!Regex.IsMatch(boxonespecial.Text, @"^(?=.*[@#$%^&+=]).*$"))

            {
                MessageBox.Show("compulsory one special character.");
                iseverythingTrue = true;
            }

            if(!iseverythingTrue)
            {
                MessageBox.Show("Everything is valid");

            }
        }
    }
}


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

namespace WpfApp6
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            int Sum = 0;
            ComboBoxItem item = (ComboBoxItem)ComboBox1.SelectedItem;
            if (item.Content.ToString() == "Sum")
            {
                Sum = Convert.ToInt32(t1.Text) + Convert.ToInt32(t2.Text);
                t3.Text = Sum.ToString();
            }

            else if(item.Content.ToString()=="Minus")
            {
                int Minus = 0;
                Minus = Convert.ToInt32(t1.Text) - Convert.ToInt32(t2.Text);
                t3.Text = Minus.ToString();
            }

           else if(item.Content.ToString()=="Multiplication")
            {
                int Multiplication = 1;
                Multiplication= Convert.ToInt32(t1.Text) * Convert.ToInt32(t2.Text);
                t3.Text = Multiplication.ToString();
           
            }

            else if(item.Content.ToString()=="Divison")
            {
                int Divison = 1;
                Divison = Convert.ToInt32(t1.Text) / Convert.ToInt32(t2.Text);
                t3.Text = Divison.ToString();
            }


        }
    }
}

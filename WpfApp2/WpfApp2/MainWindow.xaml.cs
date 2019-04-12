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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;
        public MainWindow(string color)
        {
            InitializeComponent();

            SolidColorBrush colorBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(color);
            ColorButton.Background = colorBrush;
            ColorButton.Content = color;
            Newtext.Text = color;
            Newtext.Foreground = colorBrush;


        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            count++;
            CounterText.Text = count.ToString();

        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            sum = Convert.ToInt32(Value1.Text) + Convert.ToInt32(Value2.Text);
            Answer.Text = sum.ToString();
        }
    }
}


using System.Windows;


namespace OOPSEx
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
            Vrunda v = new Vrunda(); // v is an object
            v.print();
        }
    }
}

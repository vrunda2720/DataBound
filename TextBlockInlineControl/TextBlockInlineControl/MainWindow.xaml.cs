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

namespace TextBlockInlineControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlockFormatting();
        }

        private void TextBlockFormatting()
        {
            //throw new NotImplementedException();
            TextBlock textBlock = new TextBlock();
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Margin = new Thickness(16);
            textBlock.Inlines.Add("Hello");
            textBlock.Inlines.Add(new Run("Welcome") { Foreground = Brushes.Green } );
            textBlock.Inlines.Add(new Run("dotprogramming.blogspot.com") { FontWeight= FontWeights.Bold});
            textBlock.Inlines.Add(",My Blog"); textBlock.Inlines.Add(new Run("Welcome") { Foreground = Brushes.Green } );
            textBlock.Inlines.Add(new Run("Start Running WPF") { FontStyle = FontStyles.Italic });
            textBlock.Inlines.Add(new Run("Learn Better") { Foreground = Brushes.Blue } );
            textBlock.Inlines.Add(new Run("From my blog") { TextDecorations = TextDecorations.Underline } );
            this.Content = textBlock;


        }
    }

    
}

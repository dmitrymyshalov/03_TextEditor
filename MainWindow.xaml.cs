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
using System.Windows.Shapes;

namespace TextEditor
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

        private void ComboBoxFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                string fontName = GetComboText(sender);
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBoxFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                string fontSize = GetComboText(sender);
                textBox.FontSize = Convert.ToDouble(fontSize);
            }
        }

        private void ToggleButtonBold_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Bold;
        }

        private void ToggleButtonBold_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Regular;
        }

        private void ToggleButtonItalic_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic;
        }

        private void ToggleButtonItalic_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Normal;
        }

        private void ToggleButtonUnderline_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations.Add(TextDecorations.Underline);
        }

        private void ToggleButtonUnderline_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
        }

        private void RadioButtonBlack_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButtonRed_Checked(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }

        private string GetComboText(object sender) =>
            ((sender as ComboBox).SelectedItem as TextBlock).Text;
    }
}
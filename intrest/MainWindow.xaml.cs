using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace intrest
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double beginCapital = double.Parse(beginTextBox.Text);
            int endCapital = int.Parse(endTextBox.Text);
            double currentCapital = beginCapital;
            double intrest = (double.Parse(intrestTextBox.Text)/100);
            int i = 1;
            StringBuilder result = new StringBuilder();
            do
            {
                currentCapital += currentCapital * intrest;
                result.AppendLine($"Wedde na {i} jaar: {currentCapital:C}.");
                i++;

            } while (currentCapital < endCapital);
            resultTextBlock.Text = result.ToString();

        }

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            beginTextBox.Clear();
            endTextBox.Clear();
            intrestTextBox.Clear();
            resultTextBlock.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
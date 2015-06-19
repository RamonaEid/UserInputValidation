using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UIV.BL;

namespace UIV.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IValidatedItem _validatedItem;

        public MainWindow(IValidatedItem validatedItem)
        {
            InitializeComponent();
            _validatedItem = validatedItem;
        }

        private void BtnValidate_Click(object sender, RoutedEventArgs e)
        {
            _validatedItem.TextString = TextBoxInputString.Text;
            Process(_validatedItem);
        }

        private void Process(IValidatedItem validatedItem)
        {
            bool result = Validate(validatedItem);
            validatedItem.MessageResult = SetMessage(result);

            FormatResults(ResultLabel, validatedItem.MessageResult);
            PopulateResultListView(ResultListView, result, validatedItem);
        }

        private void PopulateResultListView(ListView resultListView, bool result, IValidatedItem validatedItem)
        {
            if (result)
                resultListView.Items.Add(validatedItem);
        }

        private void FormatResults(Label resultLabel, string msg)
        {
            resultLabel.Foreground = Brushes.Black;
            switch (msg)
            {
                case "Bingo!":
                    if ((ResultListView.Items.Count % 2) == 0)
                    {
                        msg += "  It Validates!";
                        resultLabel.Foreground = Brushes.Blue; 
                    }
                    else
                    {
                        msg = "You are a Winner!";
                        resultLabel.Foreground = Brushes.Green;
                    }
                    break;
                case "Oops!":
                    msg += "  Try again!";
                    resultLabel.Foreground = Brushes.Red;
                    break;
            }
            resultLabel.Content = msg;
            resultLabel.FontSize = 24;
            resultLabel.FontWeight = FontWeight.FromOpenTypeWeight(999);

        }

        private string SetMessage(bool result)
        {
            return result ? "Bingo!" : "Oops!";
        }

        private bool Validate(IValidatedItem inputString)
        {
            return Validator.IsValid(inputString.TextString);
        }

        private void TextBoxInputString_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxInputString.Text = "";
            ResultLabel.Content = "";
        }
    }
}

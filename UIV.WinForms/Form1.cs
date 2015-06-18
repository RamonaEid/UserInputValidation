using System;
using System.Drawing;
using System.Windows.Forms;
using UIV.BL;

namespace UIV.WinForms
{
    public partial class Form1 : Form
    {
        private IValidatedItem _validatedItem;

        public Form1(IValidatedItem validatedItem)
        {
            InitializeComponent();
            _validatedItem = validatedItem;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            _validatedItem.TextString = TextBoxInputString.Text;
            Process(_validatedItem);
        }

        private void Process(IValidatedItem validatedItem)
        {
            bool result = Validate(validatedItem);
            validatedItem.MessageResult = SetMessageResult(result);

            FormatResults(ResultLabel, validatedItem.MessageResult);
            PopulateResultListView(ResultListView, result, _validatedItem);
        }

        private void PopulateResultListView(ListView resultListView, bool result, IValidatedItem validatedItem)
        {
            if (result)
                resultListView.Items.Add(validatedItem.TextString);
        }

        private void FormatResults(Label resultLabel, string msg)
        {
            resultLabel.ForeColor = Color.Black;
            switch (msg)
            {
                case "Bingo!":
                    if ((ResultListView.Items.Count % 2) == 0)
                    {
                        msg += "  It Validates!";
                        resultLabel.ForeColor = Color.Blue;
                    }
                    else
                    {
                        msg = "You are a Winner!";
                        resultLabel.ForeColor = Color.Green;
                    }
                    break;
                case "Oops!":
                    msg += "  Try again!";
                    resultLabel.ForeColor = Color.Red;
                    break;
            }
            resultLabel.Text = msg;
        }

        private string SetMessageResult(bool result)
        {
            var messageResult = "";
            if (result)
            {
                messageResult = "Bingo!";
            }
            else
            {
                messageResult = "Oops!";
            }
            return messageResult;
        }

        private bool Validate(IValidatedItem inputString)
        {
            return Validator.IsValid(inputString.TextString);
        }

        private void TextBoxInputString_Enter(object sender, EventArgs e)
        {
            TextBoxInputString.Text = "";
            ResultLabel.Text = "";
        }
    }
}

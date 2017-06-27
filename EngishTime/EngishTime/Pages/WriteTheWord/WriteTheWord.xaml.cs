using EngishTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngishTime.Pages.WriteTheWord
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WriteTheWord : ContentPage
    {
        private Word _currentCheckWord;
        public WriteTheWord()
        {
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            var words = App.Database.GetItems().ToList();
            int wordsCount = words.Count;
            Random rnd = new Random();

            /**/

            int checkWordNumber = rnd.Next(0, wordsCount);
            _currentCheckWord = words[checkWordNumber];

            questionWord.Text = _currentCheckWord.Ru;
        }

        private async void checkButton_Clicked(object sender, EventArgs e)
        {
            checkWordEntry.IsEnabled = false;
            checkButton.IsEnabled = false;
            if (_currentCheckWord.En.ToLower() == checkWordEntry.Text.ToLower())
            {
                AnswerText.Text = "Yes, you right!";
                AnswerAlert.BackgroundColor = Color.FromHex("#8BC34A");
                AnswerText.BackgroundColor = Color.FromHex("#8BC34A");
                AnswerAlert.IsVisible = true;
                await Task.Delay(2000);
                AnswerAlert.IsVisible = false;
            }
            else
            {
                AnswerText.Text = "No, you wrong!";
                AnswerAlert.BackgroundColor = Color.FromHex("#FF7043");
                AnswerText.BackgroundColor = Color.FromHex("#FF7043");
                AnswerAlert.IsVisible = true;
                await Task.Delay(2000);
                AnswerAlert.IsVisible = false;
            }
            checkWordEntry.Text = string.Empty;
            Populate();
            checkWordEntry.IsEnabled = true;
            checkButton.IsEnabled = true;
        }
    }
}
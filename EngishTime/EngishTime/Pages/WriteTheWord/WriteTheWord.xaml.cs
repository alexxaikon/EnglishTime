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
            if(_currentCheckWord.En.ToLower() == checkWordEntry.Text.ToLower())
            {
                AnswerAlert.Text = "Yes, you right!";
                AnswerAlert.BackgroundColor = Color.FromHex("#4CAF50");
                AnswerAlert.IsVisible = true;
                await Task.Delay(2000);
                AnswerAlert.IsVisible = false;
            }
            else
            {
                AnswerAlert.Text = "No, you wrong!";
                AnswerAlert.BackgroundColor = Color.FromHex("#FF7043");
                AnswerAlert.IsVisible = true;
                await Task.Delay(2000);
                AnswerAlert.IsVisible = false;
            }
            checkWordEntry.Text = string.Empty;
            Populate();
        }
    }
}
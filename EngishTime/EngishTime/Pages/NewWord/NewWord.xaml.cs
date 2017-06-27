using EngishTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngishTime.Pages.NewWord
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewWord : ContentPage
    {
        private Word _existingWord;

        public NewWord()
        {
            InitializeComponent();
            deleteButton.IsVisible = false;
        }

        public NewWord(Word existingWord)
        {
            InitializeComponent();
            _existingWord = existingWord;
            if(_existingWord.Id != 0)
            {
                EnWordEntry.Text = _existingWord.En;
                RuWordEntry.Text = _existingWord.Ru;
                deleteButton.IsVisible = true;
            }
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EnWordEntry.Text) && !string.IsNullOrEmpty(RuWordEntry.Text))
            {
                Word word = new Word()
                {
                    En = EnWordEntry.Text,
                    Ru = RuWordEntry.Text
                };
                if (_existingWord != null)
                {
                    word.Id = _existingWord.Id;
                }
                int resultId = App.Database.SaveItem(word);
                if(resultId != 0)
                {
                    if(_existingWord == null)
                    {
                        saveButton.IsEnabled = false;
                        EnWordEntry.IsEnabled = false;
                        RuWordEntry.IsEnabled = false;
                        SaveAlert.IsVisible = true;
                        await Task.Delay(2000);
                        saveButton.IsEnabled = true;
                        EnWordEntry.IsEnabled = true;
                        RuWordEntry.IsEnabled = true;
                        SaveAlert.IsVisible = false;
                        EnWordEntry.Text = "";
                        RuWordEntry.Text = "";
                    }
                    else
                    {
                        await Navigation.PopAsync(true);
                    }
                }
            }
        }

        private async void deleteButton_Clicked(object sender, EventArgs e)
        {
            if (_existingWord.Id != 0)
            {
                int resultId = App.Database.DeleteItem(_existingWord.Id);
                if (resultId != 0)
                {
                    EnWordEntry.Text = "";
                    RuWordEntry.Text = "";
                    await Navigation.PopAsync(true);
                }
            }


        }
    }
}
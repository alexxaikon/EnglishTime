using EngishTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngishTime.Pages.Vocabulary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vocabulary : ContentPage
    {
        private List<Word> _words;

        public Vocabulary()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _words = App.Database.GetItems().ToList();
            Populate();
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Word selectedItem = ((Word)((ListView)sender).SelectedItem);
            await Navigation.PushAsync(new EngishTime.Pages.NewWord.NewWord(selectedItem), true);
        }

        private void FindEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            List<Word> filtredWords = new List<Word>();
            if(!string.IsNullOrEmpty(FindEntry.Text))
            {
                foreach(var word in _words)
                {
                    if(word.En.ToLower().Contains(FindEntry.Text.ToLower()))
                    {
                        filtredWords.Add(word);
                    }
                }
            }
            else
            {
                filtredWords = _words;
            }
            wordList.ItemsSource = filtredWords;
        }

        private void englishButton_Clicked(object sender, EventArgs e)
        {
            russianUnderLine.IsVisible = false;
            englishUnderLine.IsVisible = true;
        }

        private void russianButton_Clicked(object sender, EventArgs e)
        {
            russianUnderLine.IsVisible = true;
            englishUnderLine.IsVisible = false;
        }
    }
}
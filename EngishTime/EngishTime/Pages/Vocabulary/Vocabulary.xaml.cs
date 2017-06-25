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
        public Vocabulary()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            List<Word> words = App.Database.GetItems().ToList();
            wordList.ItemsSource = words;
            base.OnAppearing();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Word selectedItem = ((Word)((ListView)sender).SelectedItem);
            await Navigation.PushAsync(new EngishTime.Pages.NewWord.NewWord(selectedItem), true);
        }
    }
}
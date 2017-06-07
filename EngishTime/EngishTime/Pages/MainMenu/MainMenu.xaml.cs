using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace EngishTime.Pages.MainMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            VocabularyXButton.XClick += vocabularyButton_Clicked;
        }



        private async void writeTheWordButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EngishTime.Pages.WriteTheWord.WriteTheWord(), true);
        }
        

        private async void guessTheWordButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EngishTime.Pages.GuessTheWord.GuessTheWord(), true);
        }
        
        /*
        private async void newWordButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EngishTime.Pages.NewWord.NewWord(), true);
        }*/

        private async void vocabularyButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EngishTime.Pages.Vocabulary.Vocabulary(), true);
        }
    }
}
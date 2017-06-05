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
        }

        private void writeTheWordButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync(true);

        }

        private void guessTheWordButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync(true);
        }

        private async void newWordButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EngishTime.Pages.NewWord.NewWord(), true);
        }

        private void vocabularyButton_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}
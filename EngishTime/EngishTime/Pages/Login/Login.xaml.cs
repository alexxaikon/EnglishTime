using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngishTime.Pages.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage //ЛАПКАзаврик =) 
    {
        public Login()
        {
            InitializeComponent();
            signInButton.BorderRadius = 30;
        }

        private void signInButton_Clicked(object sender, EventArgs e)
        {

            App.Current.MainPage = new NavigationPage(new EngishTime.Pages.MainMenu.MainMenu())
            {
                BarBackgroundColor = Color.FromHex("#673AB7")
            };

            //await Navigation.PushAsync(new EngishTime.Pages.MainMenu.MainMenu(),true);
        }
    }
}
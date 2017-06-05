using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngishTime.Pages.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            signInButton.BorderRadius = 30;
        }

        private async void signInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EngishTime.Pages.MainMenu.MainMenu(),true);
        }
    }
}
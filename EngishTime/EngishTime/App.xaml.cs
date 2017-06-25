using EngishTime.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

///[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EngishTime
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "EnglishTime.db";
        public static WordRepository database;
        public static WordRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new WordRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new EngishTime.Pages.Login.Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

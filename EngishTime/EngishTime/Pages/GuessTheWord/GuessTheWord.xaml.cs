using EngishTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngishTime.Pages.GuessTheWord
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GuessTheWord : ContentPage
    {
        private int _sureBtnNum;

        public GuessTheWord()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Populate();
            base.OnAppearing();
        }

        private void Populate()
        {
            var words = App.Database.GetItems().ToList();
            int wordsCount = words.Count;
            Random rnd = new Random();

            /**/

            int checkWordNumber = rnd.Next(0,wordsCount);

            /**/

            var rndWordNumbers = new List<int>();
            while(rndWordNumbers.Count != 3)
            {
                int rndWordNumber = rnd.Next(0,wordsCount);
                if (!rndWordNumbers.Contains(rndWordNumber) && checkWordNumber != rndWordNumber)
                {
                    rndWordNumbers.Add(rndWordNumber);
                }
            }

            var rndBtnNumbers = new List<int>();
            while (rndBtnNumbers.Count != 3)
            {
                int rndBtnNumber = rnd.Next(1,5);
                if (!rndBtnNumbers.Contains(rndBtnNumber))
                {
                    rndBtnNumbers.Add(rndBtnNumber);
                }
            }

            var defBtnNums = new List<int>() { 1, 2, 3, 4 };
            var sureBtnNumList = defBtnNums.Except(rndBtnNumbers);

            _sureBtnNum = sureBtnNumList.FirstOrDefault();

            /**/

            var currentCheckWord = words[checkWordNumber];

            for(int j=0;j<= rndBtnNumbers.Count-1; j++ )
            {
                FillButtons(rndBtnNumbers[j], words[rndWordNumbers[j]].En);
            }
            FillButtons(_sureBtnNum, currentCheckWord.En);

            checkWord.Text = currentCheckWord.Ru;
        }

        private void FillButtons(int num, string text)
        {
            if (num == 1)
            {
                checkAButton.Text = text;
            }
            if (num == 2)
            {
                checkBButton.Text = text;
            }
            if (num == 3)
            {
                checkCButton.Text = text;
            }
            if (num == 4)
            {
                checkDButton.Text = text;
            }
        }

        private async void checkAButton_Clicked(object sender, EventArgs e)
        {
            if(1 == _sureBtnNum)
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#4CAF50");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            else
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#FF7043");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            Populate();
        }

        private async void checkBButton_Clicked(object sender, EventArgs e)
        {
            if (2 == _sureBtnNum)
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#4CAF50");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            else
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#FF7043");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            Populate();
        }

        private async void checkCButton_Clicked(object sender, EventArgs e)
        {
            if (3 == _sureBtnNum)
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#4CAF50");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            else
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#FF7043");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            Populate();
        }

        private async void checkDButton_Clicked(object sender, EventArgs e)
        {
            if (4 == _sureBtnNum)
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#4CAF50");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            else
            {
                ((Button)sender).BackgroundColor = Color.FromHex("#FF7043");
                await Task.Delay(2000);
                ((Button)sender).BackgroundColor = Color.White;
            }
            Populate();
        }
    }
}
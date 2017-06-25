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
        public GuessTheWord()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
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
                int rndBtnNumber = rnd.Next(4);
                if (!rndBtnNumbers.Contains(rndBtnNumber))
                {
                    rndBtnNumbers.Add(rndBtnNumber);
                }
            }

            var defBtnNums = new List<int>() { 1, 2, 3, 4 };
            var sureBtnNumList = defBtnNums.Except(rndBtnNumbers);

            int sureBtnNum = sureBtnNumList.FirstOrDefault();

            /**/

            var currentCheckWord = words[checkWordNumber];

            for(int j=0;j<= rndBtnNumbers.Count-1; j++ )
            {
                FillButtons(rndBtnNumbers[j], words[rndWordNumbers[j]].En);
            }
            FillButtons(sureBtnNum, currentCheckWord.En);

            checkWord.Text = currentCheckWord.Ru;

            base.OnAppearing();
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

    }
}
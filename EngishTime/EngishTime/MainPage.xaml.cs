using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EngishTime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ToolbarItems.Add(new ToolbarItem("Search", "", () =>
            {
                //logic code goes here
            },ToolbarItemOrder.Primary));

        }
    }
}

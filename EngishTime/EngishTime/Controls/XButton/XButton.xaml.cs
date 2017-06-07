using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EngishTime.Controls
{
    public partial class XButton : ContentView
    {
        public XButton()
        {
            InitializeComponent();
            //ImageForButton.Source = XImageSource;
        }

        public EventHandler XClick { get; set; }

        public static BindableProperty XImageSourceProperty =
    BindableProperty.Create("XImageSource", // название обычного свойства
        typeof(string), // возвращаемый тип 
        typeof(XButton), // тип,  котором объявляется свойство
        "",// значение по умолчанию
        defaultBindingMode:BindingMode.TwoWay
    );
        public string XImageSource
        {
            set
            {
                SetValue(XImageSourceProperty, value);
            }
            get
            {
                var t = (string)GetValue(XImageSourceProperty);
                return (string)GetValue(XImageSourceProperty);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            XClick?.Invoke(sender,e);
        }

        private void ImageClick(object sender, EventArgs e)
        {
            XClick?.Invoke(sender, e);
        }
    }
}
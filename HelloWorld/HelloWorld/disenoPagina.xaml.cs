using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class disenoPagina : ContentPage
    {
        
        public disenoPagina()
        {
            InitializeComponent();
            //Thickness bordes = new Thickness();
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        bordes = new Thickness(0, 50, 0, 0);
            //        break;
            //    case Device.Android:
            //        bordes = new Thickness(0, 0, 0, 0);
            //        break;
            //    case Device.UWP:
            //        bordes = new Thickness(0, 0, 0, 0);
            //        break;
            //}
            //Padding = bordes;
        }

    }
}
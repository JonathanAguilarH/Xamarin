using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace HelloWorld
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            deslizador.Value = 0.5;
            // para poner límites en las aplicaciones, primero se pregunta en qué dispositivo va a correr la app
            Thickness bordes = new Thickness();
            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    bordes = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    bordes = new Thickness(0, 0, 0, 0);
                    break;
                case Device.UWP:
                    bordes =new Thickness(0, 0, 0, 0);
                    break;
            }
            Padding = bordes;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sabía que lo harías", "Bueno, eso fue todo... Presiona el botón de abajo", "Si, ESTE botón");
        }
    }
}

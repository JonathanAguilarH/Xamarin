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
    public partial class vistaFrases : ContentPage
    {
        int index = 0;
        string[] frases = new string[] { "Locura es hacer lo mismo una y otra vez esperando obtener resultados diferentes.", "Hay dos cosas infinitas: el universo y la estupidez humana. Y del universo no estoy seguro.",
                "En medio de la dificultad yace la oportunidad.", "Si no lo puedes explicar de forma simple, no lo entiendes suficientemente bien.", "Quien nunca ha cometido un error nunca ha intentado nada nuevo.",
                "Intenta no volverte un hombre de éxito, sino volverte un hombre de valor.", "Cualquier tonto puede saber. El punto es entender.", "No tengo talentos especiales, pero sí soy profundamente curioso.",
                "Si quieres vivir una vida feliz, átala a una meta, no a una persona o a un objeto.", "La coincidencia es la forma en que Dios permanece anónimo."};
        public vistaFrases()
        {
            InitializeComponent();
            Thickness bordes = new Thickness();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    bordes = new Thickness(0, 50, 0, 0);
                    break;
                case Device.Android:
                    bordes = new Thickness(0, 0, 0, 0);
                    break;
                case Device.UWP:
                    bordes = new Thickness(0, 0, 0, 0);
                    break;
            }
            Padding = bordes;
            lblFrase.Text = frases[index];
        }
        private void btnSiguiente_Clicked(object sender, EventArgs e)
        {
            this.index++;
            if (index >= frases.Length)
            {
                this.index = 0;
            }
            lblFrase.Text = frases[index];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encuestas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetallesEncuestasView : ContentPage
	{
        private readonly string[] equipos = { "Colombia", "peru", "brasil"};

		public DetallesEncuestasView ()
		{
			InitializeComponent ();
            BtAgregarEq.Clicked += BtAgregarEq_Clicked;
		}

        private async void BtAgregarEq_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntNombre.Text) || string.IsNullOrEmpty(LbEquipoFav.Text)) {

                await DisplayAlert("Datos Incompletos",
                    "Por favor ingrese los campos", "Aceptar");

                return;
            }

            var enc = new Encuesta()
        }
    }
}
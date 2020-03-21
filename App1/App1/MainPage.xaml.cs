using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async void Registra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrar());
        }

        protected async void Consulta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Consultar());
        }

        protected async void Actualiza_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Actualizar());
        }

        protected async void Elimina_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Eliminar());
        }
    }
}

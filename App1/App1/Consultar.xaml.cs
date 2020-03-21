using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Consultar : ContentPage
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Persona encontrado = App.DB.GetPersona(BuscarN.Text);
            try
            {
                int id = encontrado.Id;
                String nombre = encontrado.Nombre.ToString();
                String apellido = encontrado.Apellido.ToString();
                String apodo = encontrado.Apodo.ToString();
                DisplayAlert("Encontrado","ID: " + id + "\n Nombre: " + nombre + "\n Apellido: " + apellido +
                    "\n Apodo: " + apodo, "Continuar");
            }
            catch
            {
                DisplayAlert("Error", "No encontrado", "Continuar");
            }
        }
    }
}
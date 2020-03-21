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
    public partial class Actualizar : ContentPage
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void BActualizar_Clicked(object sender, EventArgs e)
        {
            Persona encontrado = App.DB.GetPersona(UNombre.Text, UApellido.Text);
            try
            {
                Persona persona = new Persona();
                string nombrep = encontrado.Nombre.ToString();
                persona.Id = Convert.ToInt32(encontrado.Id.ToString());
                persona.Nombre = nombrep;
                persona.Apellido = encontrado.Apellido.ToString();
                persona.Apodo = UApodo.Text;
                int res = App.DB.Actuali(persona);
                DisplayAlert("Actualizado", nombrep, "Continuar");
                UNombre.Text = "";
                UApellido.Text = "";
                UApellido.Text = "";
                UApodo.Text = "";
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", "No se ha podido actualizar los datos", "Continuar");
            }
        }
    }
}
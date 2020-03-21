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
    public partial class Eliminar : ContentPage
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            Persona encontrado = App.DB.GetPersona(DNombre.Text, DApellido.Text);
            try
            {
                Persona persona = new Persona();
                string nombres = encontrado.Nombre.ToString();
                persona.Id = Convert.ToInt32(encontrado.Id.ToString());
                persona.Nombre = nombres;
                persona.Apellido = encontrado.Apellido.ToString();
                persona.Apodo = encontrado.Apodo.ToString();
                int resa = App.DB.Elimina(persona);
                DisplayAlert("Eliminado", "El registro ha sido eliminado", "Continuar");
                DNombre.Text = "";
                DApellido.Text = "";
            }catch(Exception ex)
            {
                DisplayAlert("Error", "No se ha podido eliminar el registro", "Continuar");
            }
        }
    }
}
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
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = Nombre.Text;
            persona.Apellido = Apellido.Text;
            persona.Apodo = Apodo.Text;
            App.DB.Registra(persona);

        }
    }
}
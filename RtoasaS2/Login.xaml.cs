using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RtoasaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {


         //   Navigation.PushAsync(new Registro(2,2));
            string usuario = "rtoasa";
            string contrasena = "12345";

            //  string tUsuario = txtUsuario.Text;
            //   string tContrasena = txtContrasena.Text;
            /*
               if (usuario == tUsuario & contrasena == tContrasena)
               {
                   DisplayAlert("Alerta", "USUARIO CORRECTO", "Cerrar");

                   Navigation.PushAsync(new Registro());
               }
               else
               {
                   DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");
               }
            */
        }

    }
}
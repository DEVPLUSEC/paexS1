using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace paexS1.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnComprobar_Clicked(object sender, EventArgs e)
        {

            var usuario = txtUsuario.Text;
            var contrasena = txtContrasena.Text;

            if (usuario == "Miguel" && contrasena == "12345") {
                Navigation.PushAsync(new inicio(usuario));
            }
            else
            {
                DisplayAlert("Comprobar datos", "Usuario o contraseña incorrectas", "Cerrar");
            }

        }
    }
}
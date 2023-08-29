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
    public partial class reporte : ContentPage
    {
        public reporte(string nom_usu, string edad, string nombre, string apellido, string salario, string direccion)
        {
            InitializeComponent();

            txtUsuaconec.Text = "Bienvenido " + nom_usu;

            datoEdad.Text = edad;
            datoNombre.Text = nombre;
            datoApellido.Text = apellido;
            datoSalario.Text = salario;
            datoDireccion.Text = direccion;
        }
    }
}
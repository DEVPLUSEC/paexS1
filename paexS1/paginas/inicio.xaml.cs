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
    public partial class inicio : ContentPage
    {
        public string edad_calculo;
        public string nom_usuario;
        public inicio(string usuario)
        {
            InitializeComponent();
            txtUsuaconec.Text = "Bienvenido " + usuario;
            this.nom_usuario = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            int anio_nacimiento = int.Parse(txtDato.Text);
            DateTime fecha = DateTime.Now;
            int anio_actualo = fecha.Year;
            int edad = 0;

            edad = anio_actualo - anio_nacimiento;

            if (edad > 0 && edad < anio_actualo)
            {

                DisplayAlert("Su edad es :", edad.ToString(), "Cerrar");

                this.edad_calculo = edad.ToString();
            }
            else
            {

                DisplayAlert("Introduzca una año de nacimiento correcto", " Debe ser mayor a 0  y menor al año actual " + anio_actualo.ToString(), "Cerrar");
            }






        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            string nom_usu = this.nom_usuario;
            string edad = this.edad_calculo.ToString();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double salario = Convert.ToDouble(txtSalario.Text);
            string direccion = txtDireccion.Text;
           


           
                Navigation.PushAsync(new reporte(nom_usu, edad, nombre,apellido,salario.ToString(), direccion));
            

        }
    }
}
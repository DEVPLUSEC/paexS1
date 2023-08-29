using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace paexS1
{
    public partial class MainPage : ContentPage
    {   
        public string usu;
        public MainPage(string usuario)
        {
           
 
            InitializeComponent();

            txtUsuaconec.Text = "Bienvenido " + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            int anio_nacimiento = int.Parse(txtDato.Text);
            DateTime fecha = DateTime.Now;
            int anio_actualo = fecha.Year;
            int edad = 0;

            edad = anio_actualo - anio_nacimiento;

            if (edad > 0 && edad < anio_actualo) {

                DisplayAlert("Su edad es :", edad.ToString(), "Cerrar");
            }
            else
            {

                DisplayAlert("Introduzca una año de nacimiento correcto"," Debe ser mayor a 0  y menor al año actual " + anio_actualo.ToString(), "Cerrar");
            }






        }
    }
}

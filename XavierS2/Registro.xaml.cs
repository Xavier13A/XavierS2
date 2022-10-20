using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XavierS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnInformción_Clicked(object sender, EventArgs e)
        {
           
            //Este ejercicio es solo para ingresar texto y numero
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota = Convert.ToDouble(txtNota.Text);

            if (nota >=7)
            {
                DisplayAlert("Mesaje de Alerta", "Tu nombre es" + nombre + "\nTu Apellidos es" + apellido + "\nAprobaste"+nota, "Cerrar");
            }
            else 
            {
                DisplayAlert("Mesaje de Alerta", "Tu nombre es" + nombre + "Tu Apellidos es" + apellido + "Reprobaste"+nota, "Cerrar");
            }


        }

       
    }
    }
    
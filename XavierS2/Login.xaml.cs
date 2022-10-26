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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string Contrasena = "uisrael2022";

            string TUsuario = txtUsuario.Text;
            string TContrasena = txtContraseña.Text;

            if (usuario == TUsuario & Contrasena == TContrasena)
            {
                DisplayAlert("Alerta", "Usuario Correcto", "Cerrar");
                Navigation.PushAsync(new Registro(txtUsuario.Text)); // activacion de a la siguiente ventana

            }    
            else
            {
                DisplayAlert( "Alerta", "Usuario no existe", "cerrar");
            }

        }
    }
}
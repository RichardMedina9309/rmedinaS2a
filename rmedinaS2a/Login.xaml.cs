using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rmedinaS2a
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
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "estudiante2023" && contraseña == "uisrael2023")
            {
                Navigation.PushAsync(new Principal());
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "CERRAR");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}
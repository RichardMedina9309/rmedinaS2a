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
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnIrNotas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Notas());
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}
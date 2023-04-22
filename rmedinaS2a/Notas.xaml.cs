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
    public partial class Notas : ContentPage
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnNombre_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DisplayAlert("Bienvenido al SIGE", "Ingresar notas de: " + nombre, "Aceptar");
        }

        private void btnPromedioDeberes_Clicked(object sender, EventArgs e)
        {
            double semana1 = Convert.ToDouble(txtDeber1.Text);
            double semana2 = Convert.ToDouble(txtDeber2.Text);
            double semana3 = Convert.ToDouble(txtDeber3.Text);
            
            double suma = semana1 + semana2 + semana3 ;
            double promedio = suma / 3;
            txtPromedioDeberes.Text = promedio.ToString();

        }

        private void btnPromedioParcialUno_Clicked(object sender, EventArgs e)
        {
            double promedio1 = Convert.ToDouble(txtPromedioDeberes.Text);
            double examen1 = Convert.ToDouble(txtExamen1.Text);

            double sumatoriatotal1 = promedio1 + examen1;
            double divisiontotal1 = sumatoriatotal1 / 2;
            double multiplicaciontotal1 = divisiontotal1 * 5;
            double promediototal1 = multiplicaciontotal1 / 10;
            txtPromedioNotas1.Text = promediototal1.ToString();

        }

        private void btnLimpiarDeberes_Clicked(object sender, EventArgs e)
        {
            txtDeber1.Text = "";
            txtDeber2.Text = "";
            txtDeber3.Text = "";
            txtPromedioDeberes.Text = "";
            txtExamen1.Text = ""; 
            txtPromedioNotas1.Text = "";
        }

        private void btnPromedioDeberes2_Clicked(object sender, EventArgs e)
        {
            double semana5 = Convert.ToDouble(txtDeber5.Text);
            double semana6 = Convert.ToDouble(txtDeber6.Text);
            double semana7 = Convert.ToDouble(txtDeber7.Text);

            double suma2 = semana5 + semana6 + semana7;
            double promedio2 = suma2 / 3;
            txtPromedioDeberes2.Text = promedio2.ToString();
        }

        private void btnPromedioParcialDos_Clicked(object sender, EventArgs e)
        {
            double promedio3 = Convert.ToDouble(txtPromedioDeberes.Text);
            double examen2 = Convert.ToDouble(txtExamen2.Text);

            double sumatoriatotal2 = promedio3 + examen2;
            double divisiontotal2 = sumatoriatotal2 / 2;
            double multiplicaciontotal2 = divisiontotal2 * 5;
            double promediototal2 = multiplicaciontotal2 / 10;
            txtPromedioNotas2.Text = promediototal2.ToString();
        }

        private void btnLimpiarDeberes2_Clicked(object sender, EventArgs e)
        {
            txtDeber5.Text = "";
            txtDeber6.Text = "";
            txtDeber7.Text = "";
            txtPromedioDeberes2.Text = "";
            txtExamen2.Text = "";
            txtPromedioNotas2.Text = "";
        }

        private void btnNotaFinal_Clicked(object sender, EventArgs e)
        {
            double promedio4 = Convert.ToDouble(txtPromedioNotas1.Text);
            double promedio5 = Convert.ToDouble(txtPromedioNotas2.Text);

            double sumafinal = promedio4 + promedio5;
            double notafinal = sumafinal / 2;

            txtNotaFinal.Text = notafinal.ToString();


        }

        private void txtDeber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double deb1 = Convert.ToDouble(txtDeber1.Text);

                if(deb1 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtDeber1.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtDeber2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double deb2 = Convert.ToDouble(txtDeber2.Text);

                if (deb2 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtDeber2.Text = "";
                }
            }
            catch (Exception ex) 
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtDeber3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double deb3 = Convert.ToDouble(txtDeber3.Text);
                if(deb3 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtDeber3.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtExamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double exam1 = Convert.ToDouble(txtExamen1.Text);
                if(exam1 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtExamen1.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtDeber5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double deb5 = Convert.ToDouble(txtDeber5.Text);
                if(deb5 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtDeber5.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtDeber6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double deb6 = Convert.ToDouble(txtDeber6.Text);
                if (deb6 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtDeber6.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }

        }

        private void txtDeber7_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double deb7 = Convert.ToDouble(txtDeber7.Text);
                if (deb7 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtDeber7.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private void txtExamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double exam2 = Convert.ToDouble(txtExamen2.Text);
                if (exam2 > 10)
                {
                    DisplayAlert("Mensaje", "Números no mayores a 10", "Cerrar");
                    txtExamen2.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }
    }
}
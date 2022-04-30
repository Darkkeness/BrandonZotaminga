using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrandonZotaminga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        String nombre;
        decimal cuota;
        public Registro(String login)
        {
            InitializeComponent();
            _usuarioCone.Text = "Usuario Conectado: " + login;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(_nombre.Text) || String.IsNullOrEmpty(_monto.Text))
            {
                DisplayAlert("Error", "No puede estar vacios los campos", "OK");
            }else
            {
                if(decimal.Parse(_monto.Text) > 3000)
                {
                    DisplayAlert("Error", "No puede ser mayor a 3000", "OK");
                }
                else
                {
                    decimal valor = 3000 - decimal.Parse(_monto.Text);
                    cuota = (valor / 5) + (3000 * (decimal)0.05);
                    _pago.Text = cuota.ToString();
                }

            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           await DisplayAlert("CORECTO", "SU TRANSACCION SE REALIZO CORRECTAMENTE", "OK");
            await Navigation.PushAsync(new Resumen(_usuarioCone.Text,_nombre.Text,cuota));

        }
    }
}
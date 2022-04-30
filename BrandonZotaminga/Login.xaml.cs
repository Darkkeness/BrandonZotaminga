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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (_usuario.Text.Equals("brandon2022") && _pass.Text.Equals("uisrael2022"))
            {
                Navigation.PushAsync(new Registro(_usuario.Text));
            }else
            {
                DisplayAlert("ERROR", "Usuario o Contraseña Incorrectos","OK");
            }
        }
    }
}
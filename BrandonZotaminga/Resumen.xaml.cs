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
    public partial class Resumen : ContentPage
    {

        decimal cuota;
        public Resumen(String login,String nombre,decimal cuota)
        {
            
            InitializeComponent();
            _usuarioCone.Text = "USUARIO CONECTADO: " + login;
            _total.Text = (cuota * 5).ToString();
            _nombre.Text = nombre;
        }


    }
}
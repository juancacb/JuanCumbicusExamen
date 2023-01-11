using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JuanCumbicusExamen.VistasExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string total, string nombre)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txttotal.Text = total;
        }

        private void btnacerca_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hola", "Examen Juan Cumbicus Noveno Sistemas", "cerrar");
        }
    }
}
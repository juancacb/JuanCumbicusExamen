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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = "USUARIO CONECTADO: " +usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double minicial = Convert.ToDouble(txtminicial.Text);
                double Pmensual = ((4000-minicial)/5)+200;  //5%4000 = 200
                txtpmensual.Text = Pmensual.ToString();
                double total = Pmensual*5 + minicial;
                lblTotal.Text = total.ToString();

                if (minicial > 4000)
                {
                    DisplayAlert("Error", "Valor No Permitido", "cerrar");
                }
                if (minicial <= 0)
                {
                    DisplayAlert("Error", "No Existe Valores", "cerrar");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            string nombre = txtNombre.Text;
            string total = lblTotal.Text;

            DisplayAlert("ELEMENTO GUARDADO CON EXITO", "", "VER RESUMEN DE RESULTADOS");
            Navigation.PushAsync(new Resumen(usuario,total, nombre));

        }
    }
}
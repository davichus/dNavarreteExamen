using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dNavarreteExamen.Vistas
{	
	public partial class Registro : ContentPage
	{	
		public Registro (string usuario)
		{
			InitializeComponent ();
			lblUsuario.Text = usuario;
		}

       private void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
			try
			{
				if (Convert.ToDouble(txtMontoInicial.Text)<=4000)
				{
                    double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
                    double Pmensual = (4000 - montoInicial) / 5 + 5 % 4000;
                    txtPagoMensual.Text = Pmensual.ToString();
				}
				else
				{
					DisplayAlert("Alerta","El monto no debe ser mayor a 4000", "Cerra");
				}
                
            }
			catch (Exception ex)
			{
				DisplayAlert("Alerta", ex.ToString(), "Cerrar");
			}
			
         }

       private void btnGuadarInf_Clicked(System.Object sender, System.EventArgs e)
        {
			string usuario = lblUsuario.Text;
			string nombre = txtNombre.Text;
			string total = txtPagoMensual.Text;

            Navigation.PushAsync(new Resumen(usuario, nombre, total));
        }
    }
}


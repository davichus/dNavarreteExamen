using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dNavarreteExamen.Vistas
{	
	public partial class Resumen : ContentPage
	{	
		public Resumen (string usuario, string nombre, string total)
		{
			InitializeComponent ();
			lblUsuario.Text = usuario;
			txtNombre.Text = nombre;
			txtTotal.Text = total;

		}

        void btnAcerca_Clicked(System.Object sender, System.EventArgs e)
        {
			DisplayAlert("Acerca de", "Este Proyecto fue desarrollado por David Navarrete, Sistemas de informacion 9A", "Aceptar");
        }
    }
}


using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dNavarreteExamen.Vistas
{	
	public partial class Login : ContentPage
	{	
		public Login ()
		{
			InitializeComponent ();
		}

        void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            bool ingresar = inisiarSesion(usuario, contrasena);
            if (ingresar)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña Incorrectos", "Cerrar");
            }

        }
        public bool inisiarSesion(string usuario, string contrasena)
        {
            bool inicio = true;
            string user = "estudiante2023";
            string pass = "uisrael2023";
            if (user == usuario && pass == contrasena)
            {
                inicio = true;
            }
            else
            {
                inicio = false;
            }
            return inicio;
        }

    }
}


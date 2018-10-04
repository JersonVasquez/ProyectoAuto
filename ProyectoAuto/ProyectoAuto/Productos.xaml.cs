using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoAuto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Productos : ContentPage
	{
		public Productos ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, false);
		}

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = boxNombre2.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
               
                var user = new Compra { Name = nombre };
                Intent intent = new Intent(this, new Compra());
                intent.PutObject("user", user);
                intent.PutString("XD", "Agregado al carrito");
                intent.StartIntent();
            }
        }
    }
}
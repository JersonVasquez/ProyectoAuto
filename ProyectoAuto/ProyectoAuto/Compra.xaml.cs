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
	public partial class Compra : ContentPage
	{
		public Compra ()
		{
            
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            Regresar.Clicked += Regresar_Clicked;
		}

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Productos());
        }

        public string Name { get; internal set; }
        public string NombreP { get; internal set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var intent = Intent.Navigation.Intent;
           var user = intent.GetObject<Compra>("user");
            var lol = intent.GetString("XD");
            DisplayAlert("Autoservicio", "Agregado al carrito", "Aceptar");
            BindingContext = user;
        }
    }
}
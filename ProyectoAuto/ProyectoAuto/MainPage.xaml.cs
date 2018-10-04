using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoAuto
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            registro.Clicked += Registro_Clicked;
            iniciar.Clicked += Iniciar_Clicked;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Iniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Registro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}

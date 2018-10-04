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
	public partial class Page2 : MasterDetailPage
	{
        public Page2 ()
		{
            InitializeComponent();
            Init();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Init()
        {
            List<Menu> menu = new List<Menu>
            {   
            new Menu { MenuTitle = "Inicio", MenuDetail = "Regreso a la pagina Principal"},    
            new Menu {MenuTitle = "Productos", MenuDetail = "Navegar a la pagina de productos"},
            new Menu {MenuTitle = "Cerrar Sesión", MenuDetail = "Cierra sesión"}
            };
            ListMenu.ItemsSource = menu;          
            Detail = new NavigationPage(new Home());
        }


         void ListMenu_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e )
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                if(menu.MenuTitle.Equals("Inicio"))
                {
                    var image = new Image { Source = "Img2.jpg" };
                    IsPresented = false;
                    Detail = new NavigationPage(new Home());
                }else if (menu.MenuTitle.Equals("Productos"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new Productos());
                }else if (menu.MenuTitle.Equals("Cerrar Sesión"))
                {
                    IsPresented = false;
                    Detail = new NavigationPage(new MainPage());
                }
            }
                }
    }

    public class Menu
    {
        public string MenuTitle
        {
            get;
            set;
        }
        public  string MenuDetail
        {
            get;
            set;
        }
    }
}
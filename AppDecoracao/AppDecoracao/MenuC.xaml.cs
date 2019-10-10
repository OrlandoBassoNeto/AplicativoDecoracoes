using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDecoracao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuC : MasterDetailPage
	{
		public MenuC ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage(new MainPage());
        }

        private void PaginaLogin_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaProdutos_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaSobre_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaNotificacoes_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaDisconectar_Tapped(object sender, EventArgs e)
        {

        }

        private void PaginaOrcamento_Tapped(object sender, EventArgs e)
        {

        }
    }
}
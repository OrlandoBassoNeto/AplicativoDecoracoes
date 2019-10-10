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
            Detail = new NavigationPage(new CadastroUsuarios());
            IsPresented = false;
        }

        private void PaginaProdutos_Tapped(object sender, EventArgs e)
        {
            
        }

        private void PaginaSobre_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TelaSobre());
        }

        private void PaginaNotificacoes_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CadastroUsuarios());
        }

        private void PaginaDisconectar_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TeladeLogin());
        }

        private void PaginaOrcamento_Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TeladeOrcamento());
        }

        private void PaginaCadastraUsuarios_Tapped(object sender, EventArgs e)
        {

        }
    }
}
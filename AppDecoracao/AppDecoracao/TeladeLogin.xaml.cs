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
	public partial class TeladeLogin : ContentPage
	{
		public TeladeLogin ()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
		}

        private async void ButtonLogar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryUsuario.Text) ||
                !string.IsNullOrEmpty(entrySenha.Text))
            {

                ModelUsuario Usu = new ModelUsuario();
                bool ResultadoLogin = Usu.usuario(entryUsuario.Text, entrySenha.Text);

                try
                {
                  if(ResultadoLogin == true)
                    {
                        await Navigation.PushAsync(new MenuC());

                    }
                  else
                    {
                        await DisplayAlert("Erro", "Não foi possivel Conectar\n Erro no Login ou Senha.", "OK");
                    }
                }
                catch (Exception EX)
                {
                    throw new Exception(EX.Message);
                }

            }
            

        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {
            entryUsuario.Text = "";
            entrySenha.Text = "";

        }
    }
}
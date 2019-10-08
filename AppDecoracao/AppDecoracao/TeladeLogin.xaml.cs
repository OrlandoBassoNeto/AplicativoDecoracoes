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

        private void ButtonLogar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryUsuario.Text) ||
            string.IsNullOrEmpty(entrySenha.Text))
            {
                DisplayAlert("ERRO!", "°Não deixe os campos em brancos.", "OK");


            }
            else if (entryUsuario.Text == "Orlando" || entrySenha.Text == "123")
            {
                Navigation.PushAsync(new MenuC());
            }

            else
            {
                DisplayAlert("ERRO!", "°Senha ou Nome Incorretos", "OK");

            }

        }

        private void ButtonLimpar_Clicked(object sender, EventArgs e)
        {
            entryUsuario.Text = "";
            entrySenha.Text = "";

        }
    }
}
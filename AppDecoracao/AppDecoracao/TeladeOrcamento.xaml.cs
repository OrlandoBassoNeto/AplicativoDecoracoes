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
	public partial class TeladeOrcamento : ContentPage
	{
		public TeladeOrcamento ()
		{
			InitializeComponent ();
            if (!string.IsNullOrEmpty(entryNomeOrcamento.Text) ||
                !string.IsNullOrEmpty(entryEnderecoOrcamento.Text))
            {
                DisplayAlert("Erro", "Não deixe os campos em branco.", "OK");
            }

                if (!string.IsNullOrEmpty(entryBairroOrcamento.Text) || 
                    !string.IsNullOrEmpty(entryTelefoneOrcamento.Text))
                {
                DisplayAlert("Erro", "Não deixe os campos em branco.", "OK");
                }

        }


        private void ButtonEnviarOrcamento_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonApagarOrcamento_Clicked(object sender, EventArgs e)
        {
            entryComplementoOrcamento.Text = "";
            entryNomeOrcamento.Text = "";
            entryEnderecoOrcamento.Text = "";
            entryComplementoOrcamento.Text = "";
            entryBairroOrcamento.Text = "";
            entryTelefoneOrcamento.Text = "";
        }
    }
}
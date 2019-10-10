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
	public partial class CadastroUsuarios : ContentPage
	{
		public CadastroUsuarios ()
		{
			InitializeComponent ();
		}

        private void ButtonConfirmar_Clicked(object sender, EventArgs e)
        {
            if(entryConfirmarSenha == entrySenha)
            {
                string SQL = $"INSERT INTO Usuarios (NOME,NomeUsuario,SENHA) VALUES ('{entryNome.Text}','{entryNomeusuario.Text}','{entrySenha.Text}')";
                ((App)Application.Current).conexao.Execute(SQL);
                DisplayAlert("Sucesso!", "Usuário Cadastrado.", "OK");
            }
            else
            {
                DisplayAlert("Erro!", "Senhas estão Diferentes.", "OK");
            }
        }
    }
}
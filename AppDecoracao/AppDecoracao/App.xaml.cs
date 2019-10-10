using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLitePCL;
using PCLExt.FileStorage.Folders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppDecoracao
{
    public partial class App : Application
    {
        public SQLite.SQLiteConnection conexao { get; private set; }


        public App()       
        {
            var pasta = new LocalRootFolder();

            var arquivo = pasta.CreateFile("BancoDecoracoes.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);

            conexao = new SQLite.SQLiteConnection(arquivo.Path);

            conexao.Execute("CREATE TABLE IF NOT EXISTS Usuarios (ID INTEGER PRIMARY KEY AUTOINCREMENT,NOME TEXT,NomeUsuario TEXT,SENHA TEXT)");

            conexao.Execute("CREATE TABLE IF NOT EXISTS Orcamento (ID INTEGER PRIMARY KEY AUTOINCREMENT,Nome TEXT,Endereco TEXT,Bairro TEXT,Complemento TEXT,Telefone INTEGER)");
            

            InitializeComponent();

            MainPage = new NavigationPage(new TeladeLogin());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

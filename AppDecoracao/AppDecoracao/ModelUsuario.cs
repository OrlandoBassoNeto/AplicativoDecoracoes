using System;
using System.Collections.Generic;
using System.Text;

namespace AppDecoracao
{   

   public class ModelUsuario
   {
        public int ID { get; set; }

        public string  NOME { get; set; }

        public string NomeUsuario { get; set;}

        public string SENHA { get; set; }

        public bool usuario(string Nome, string Senha)
        {
            
                var SQL = $"SELECT COUNT(*)FROM Usuarios WHERE NomeUsuario ='{Nome}'AND SENHA = '{Senha}'";
                return true;
            
        }

    }
}

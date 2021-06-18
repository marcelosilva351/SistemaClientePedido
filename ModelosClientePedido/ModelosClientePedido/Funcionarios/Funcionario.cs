using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosClientePedido.Funcionarios
{
   public class Funcionario
    {
        public int id { get; }
        public string Nome { get; set; }
        public Endereco endereco { get; set; }
        public string Login { get; private set; }
        public string  Senha { get; private set; }

        

        public Funcionario( string nome, Endereco endereco, string login, string senha)
        {
            Random numeroIdFuncionario = new Random();
            this.id = numeroIdFuncionario.Next();
            Nome = nome;
            this.endereco = endereco;
            Login = login;
            Senha = senha;
        }
    }
}

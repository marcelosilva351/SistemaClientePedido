using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosClientePedido.Funcionarios;
using System.Runtime;
namespace ModelosClientePedido
{
    public class Pedidos
    {
        public int IdPedido { get; private set; }
        public string Descrição { get; set; }

        Funcionario funcionario;

        Restaurante restaurante;

        public Pedidos(int idPedido, string descrição, Funcionario func, Restaurante rest)
        {
            Random numeroIdPedido = new Random();
            IdPedido = numeroIdPedido.Next();
            Descrição = descrição;
            funcionario = func;
            restaurante = rest;
        }
    }
}

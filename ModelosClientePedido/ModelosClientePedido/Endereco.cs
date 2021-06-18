using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosClientePedido
{
    public class Endereco
    {
        public string Quadra { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Referencia { get; set; }

        public Endereco(string quadra, int numero, string cidade, string referencia)
        {
            Quadra = quadra;
            Numero = numero;
            Cidade = cidade;
            Referencia = referencia;
        }
    }
}

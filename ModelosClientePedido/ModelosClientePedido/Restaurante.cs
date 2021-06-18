using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosClientePedido
{
    public class Restaurante
    {
        public int IdRestaurante { get; }
        public string Nome { get; set; }

        public List<String> lanches = new List<string>();

        public Endereco endereco { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public Restaurante()
        {
          
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestranAPI.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
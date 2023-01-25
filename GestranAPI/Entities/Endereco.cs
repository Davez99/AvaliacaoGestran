using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestranAPI.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public Int32 CEP { get; set; }
        public string Rua { get; set; }
        public Int32 Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string País { get; set; }

    }
}
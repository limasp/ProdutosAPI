using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosAPI.Models
{
    public class Midia
    {
        public int Id { get; set; }
        public string NomeMidia { get; set; }
        public Produto Produto { get; set; }
    }
}

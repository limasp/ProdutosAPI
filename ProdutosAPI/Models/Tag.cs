using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosAPI.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string NomeTag { get; set; }
        public Produto Produto { get; set; }
    }
}

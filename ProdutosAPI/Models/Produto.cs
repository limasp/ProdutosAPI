using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal ComparacaoPreco { get; set; }
        public bool Status { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Midia> Midias { get; set; }
        public List<Tag> Tags { get; set; }
    }
}

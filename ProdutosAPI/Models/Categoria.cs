namespace ProdutosAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
        public Produto Produto { get; set; }
    }
}

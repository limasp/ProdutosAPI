namespace ProdutosAPI.Models
{
    public class Midia
    {
        public int Id { get; set; }
        public string NomeMidia { get; set; }
        public Produto Produto { get; set; }
    }
}

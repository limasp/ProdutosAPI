namespace ProdutosAPI.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string NomeTag { get; set; }
        public Produto Produto { get; set; }
    }
}

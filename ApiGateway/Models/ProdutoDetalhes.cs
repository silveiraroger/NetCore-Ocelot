namespace ApiGateway.Models
{
    public class ProdutoDetalhes : Produto
    {
        public decimal Preco { get; set; }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class ProdutoPreco
    {
        public int ProdutoId { get; set; }
        public decimal Preco { get; set; }
    }
}

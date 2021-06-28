using ProdutosApi.Models;
using System.Collections.Generic;

namespace ProdutosApi.Helpers
{
    public static class ProdutosFactoryHelper
    {
        public static List<Produto> CriarProdutos()
        {
            return new List<Produto>
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Cadeira Gamer DX Racer",
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Notebook HP I5",
                },
                new Produto
                {
                    Id = 3,
                    Nome = "Mouse Razor",
                },
                new Produto
                {
                    Id = 4,
                    Nome = "Monitor Concórdia 32",
                },
                new Produto
                {
                    Id = 5,
                    Nome = "Teclado Razor",
                }
            };
        }
    }
}

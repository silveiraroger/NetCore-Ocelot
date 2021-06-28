using ProdutosPrecoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosPrecoApi.Helpers
{
    public static class ProdutosPrecoFactoryHelper
    {
        public static List<ProdutoPreco> CriarProdutosPreco()
        {
            return new List<ProdutoPreco>
            {
                new ProdutoPreco
                {
                    ProdutoId = 1,
                    Preco = 960,
                },
                new ProdutoPreco
                {
                    ProdutoId = 2,
                    Preco = 3500,
                },
                new ProdutoPreco
                {
                    ProdutoId = 3,
                    Preco = 150.99M,
                },
                new ProdutoPreco
                {
                    ProdutoId = 4,
                    Preco = 1500,
                },
                new ProdutoPreco
                {
                    ProdutoId = 5,
                    Preco = 199.99M,
                }
            };
        }
    }
}

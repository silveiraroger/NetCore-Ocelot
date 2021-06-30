using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProdutosApi.Helpers;
using ProdutosApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProdutosApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IEnumerable<Produto> Produtos;

        public ProdutosController()
        {
            Produtos = ProdutosFactoryHelper.CriarProdutos();
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return Produtos;
        }

        [HttpGet("{id:int}")]
        public Produto Get(int id)
        {
            return Produtos.Where(x => x.Id == id).SingleOrDefault();
        }

        [HttpPost()]
        public Produto Post([FromBody] Produto produto)
        {
            produto.Id = 99;
            return produto;
        }
    }
}

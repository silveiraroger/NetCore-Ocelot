using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProdutosPrecoApi.Helpers;
using ProdutosPrecoApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProdutosPrecoApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProdutosPrecoController : ControllerBase
    {
        private readonly IEnumerable<ProdutoPreco> ProdutosPrecos;

        public ProdutosPrecoController()
        {
            ProdutosPrecos = ProdutosPrecoFactoryHelper.CriarProdutosPreco();
        }

        [HttpGet("{id:int}")]
        public ProdutoPreco Get(int id)
        {
            return ProdutosPrecos.Where(x => x.ProdutoId == id).SingleOrDefault();
        }
    }
}

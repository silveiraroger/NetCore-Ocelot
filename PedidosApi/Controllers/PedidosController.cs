using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PedidosApi.Helpers;
using PedidosApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace PedidosApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IEnumerable<Pedido> Pedidos;

        public PedidosController()
        {
            Pedidos = PedidosFactoryHelper.CriarPedidos();
        }

        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return Pedidos;
        }

        [HttpGet("{id:int}")]
        public Pedido Get(int id)
        {
            return Pedidos.Where(x => x.Id == id).SingleOrDefault();
        }

        [HttpPost()]
        public Pedido Post([FromBody] Pedido pedido)
        {
            pedido.Id = 99;
            return pedido;
        }
    }
}

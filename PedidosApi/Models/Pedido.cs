using System;

namespace PedidosApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }
}

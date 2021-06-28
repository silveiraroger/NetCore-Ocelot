using PedidosApi.Models;
using System;
using System.Collections.Generic;

namespace PedidosApi.Helpers
{
    public static class PedidosFactoryHelper
    {
        public static List<Pedido> CriarPedidos()
        {
            return new List<Pedido>
            {
                new Pedido
                {
                    Id = 1,
                    Cliente = "João da Silva",
                    Data = new DateTime(2021, 06, 2, 10, 55, 48),
                    Valor = 85.99m
                },
                new Pedido
                {
                    Id = 2,
                    Cliente = "Paulo Pereira",
                    Data = new DateTime(2021, 06, 5, 15, 24, 12),
                    Valor = 355.25m
                },
                new Pedido
                {
                    Id = 3,
                    Cliente = "Rodrigo Santos",
                    Data = new DateTime(2021, 06, 8, 14, 01, 54),
                    Valor = 125.00m
                },
                new Pedido
                {
                    Id = 4,
                    Cliente = "Bruna  Peixoto",
                    Data = new DateTime(2021, 06, 15, 8, 45, 02),
                    Valor = 50.00m
                },
                new Pedido
                {
                    Id = 5,
                    Cliente = "Julia Santos",
                    Data = new DateTime(2021, 06, 18, 17, 12, 36),
                    Valor = 99.00m
                }
            };
        }
    }
}

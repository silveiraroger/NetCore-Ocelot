using ApiGateway.Models;
using Microsoft.AspNetCore.Http;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace ApiGateway.Aggregators
{
    public class ProdutoDetalhesAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var resultingAggregation = new ResultingAggregation<ProdutoDetalhes>();

            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                var produtoDetalhes = await responses[0].Items.DownstreamResponse().Content.ReadAsAsync<ProdutoDetalhes>();

                try
                {
                    var produtoPreco = await responses[1].Items.DownstreamResponse().Content.ReadAsAsync<ProdutoPreco>();

                    produtoDetalhes.Preco = produtoPreco.Preco;

                    resultingAggregation.Ok(produtoDetalhes);
                }
                catch (Exception)
                {
                    resultingAggregation.Partial(produtoDetalhes, "Ocorreu um erro ao carregar dados do produto.");
                }
            }
            catch (Exception)
            {
                resultingAggregation.Error("Ocorreu um erro ao carregar os detalhes do produto.");
            }

            response.Content = new ObjectContent<ResultingAggregation<ProdutoDetalhes>>(resultingAggregation, new JsonMediaTypeFormatter());

            return new DownstreamResponse(response);
        }
    }
}

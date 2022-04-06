using CalculoJurosAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CalculoJurosAPI.Controllers
{
    [ApiController]
    public class CalculaJurosController : Controller
    {
        private readonly IJurosComposto _jurosComposto;
        private readonly IConfiguration _configuration;

        public CalculaJurosController(IJurosComposto jurosComposto, IConfiguration configuration)
        {
            _jurosComposto = jurosComposto;
            _configuration = configuration;
        }


        /// <summary>
        /// Calculo juros
        /// </summary>
        /// <remarks>
        /// Exemplo de uso:
        ///     ?valorInicial=100&meses=5
        ///     
        ///     {
        ///        "valorInicial": 100
        ///        "meses": 5
        ///     }
        ///
        /// </remarks>
        /// <param name="Calculo Juros"></param>
        /// <returns>Retorna <see cref="int"/></returns>
        /// <response code="200">Retorna o valor com juros calculado</response>
        /// <response code="400">Formato de envio invalido</response>
        /// <response code="401">Não autorizado</response>
        /// <response code="403">Não permitido</response>
        /// <response code="404">Não foi encontrado</response>
        /// <response code="500">Erro de acesso ao servidor</response>
        [HttpGet("calculajuros")]
        [ProducesResponseType(typeof(IActionResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ObterCalculoDeJuros([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            if (meses <= 0 || valorInicial < 0 || meses.Equals(null) || valorInicial.Equals(null))
                return BadRequest();

            //var taxaJuros = await _reqServices.GetTaxaJuros(_configuration.GetValue<string>("Endpoints:UrlTaxaJuros"));

            return Ok(_jurosComposto.CalculoDeJuros(valorInicial, meses));
        }
    }
}

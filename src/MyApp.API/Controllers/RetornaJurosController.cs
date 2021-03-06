﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.API.ViewModels;
using MyApp.Business.Models;

namespace MyApp.API.Controllers
{
    [Route("api/retornajuros")]
    [ApiController]
    public class RetornaJurosController : ControllerBase
    {
        /// <summary>
        ///     Retorna a taxa de juros fixa no código
        /// </summary>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult RetornaValorJuros()
        {
            return Ok(new Retorno(true, "O valor de juros foi recebido com sucesso", new { valorJuros = Juros.ValorJuros }));
        }
    }
}

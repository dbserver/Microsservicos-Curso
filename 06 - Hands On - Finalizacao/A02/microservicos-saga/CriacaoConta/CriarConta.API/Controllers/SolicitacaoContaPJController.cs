using CriarConta.API.Contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace CriarConta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SolicitacaoContaPJController : Controller
    {
        private readonly ILogger<SolicitacaoContaPJController> _logger;
        private readonly IPublishEndpoint _publishEndpoint;

        public SolicitacaoContaPJController(
            ILogger<SolicitacaoContaPJController> logger,
            IPublishEndpoint publishEndpoint)
        {
            this._logger = logger;
            this._publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ContaPJSolicitada contaPj)
        {
            var idConta = Guid.NewGuid();
            contaPj.CriarContaPJ.IdConta = idConta;
            contaPj.ValidadorContaPJ.IdConta= idConta;
            

            await _publishEndpoint.Publish(contaPj);
            return Ok(contaPj);
        }
    }
}

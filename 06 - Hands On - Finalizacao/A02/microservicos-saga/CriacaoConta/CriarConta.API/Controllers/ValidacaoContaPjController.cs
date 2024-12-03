using ContaPF.API.Commands;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace CriarConta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValidacaoContaPjController : Controller
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public ValidacaoContaPjController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpPost]
        public async Task<IActionResult> Index(ValidadorContaPJ request)
        {
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:validador-conta-pj"));

            await endpoint.Send<ValidadorContaPJ>(request);

            return Ok();
        }
    }
}

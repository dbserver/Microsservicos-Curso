using ContaPJ.API.Commands;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace CriarConta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CriacaoContaPJController : Controller
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public CriacaoContaPJController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        [HttpPost]
        public async Task<IActionResult> Index(CriarContaPJ request)
        {
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:criar-conta"));

            await endpoint.Send<CriarContaPJ>(request);

            return Ok();
        }
    }
}

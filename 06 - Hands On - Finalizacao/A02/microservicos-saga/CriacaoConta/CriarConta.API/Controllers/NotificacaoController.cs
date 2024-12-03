using MassTransit;
using Microsoft.AspNetCore.Mvc;
using NotificadorCriacaoConta.API.Commands;

namespace CriarConta.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificacaoController : Controller
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public NotificacaoController(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        // GET
        [HttpPost]
        public async Task<IActionResult> Index(NotificarCadastro request)
        {
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:notificar-cadastro"));

            await endpoint.Send<NotificarCadastro>(request);

            return Ok();
        }
    }
}

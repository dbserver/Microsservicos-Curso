using ContratosNuget.Rest;
using Microsoft.AspNetCore.Mvc;

namespace ServicoLegado.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Post")]
        public async Task<bool> Post(ClienteDto clienteDto)
        {
            return await Task.FromResult(true);
        }
    }
}

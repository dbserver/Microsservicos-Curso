using ContratosNuget.Rest;
using Microsoft.AspNetCore.Mvc;

namespace ServicoLegado.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Post")]
        public bool Post(ClienteDto clienteDto)
        {
            return true;
        }
    }
}

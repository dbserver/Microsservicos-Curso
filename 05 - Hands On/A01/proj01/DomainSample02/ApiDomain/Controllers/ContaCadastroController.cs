using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiDomain.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCadastroController : ControllerBase
    {
        private readonly IAberturaContaService aberturaContaService;

        public ContaCadastroController(IAberturaContaService aberturaContaService)
        {
            this.aberturaContaService = aberturaContaService;
        }

        [HttpPost]
        public async Task Post()
        {
            aberturaContaService.CriarConta();
        }
    }
}

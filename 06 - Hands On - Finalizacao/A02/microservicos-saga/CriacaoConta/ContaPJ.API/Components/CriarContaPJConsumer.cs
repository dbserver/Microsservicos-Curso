using ContaPJ.API.Commands;
using ContaPJ.API.Events;
using MassTransit;

namespace ContaPJ.API.Components
{
    public class CriarContaPJConsumer : IConsumer<CriarContaPJ>
    {
        private readonly ILogger<CriarContaPJ> _logger;

        public CriarContaPJConsumer(ILogger<CriarContaPJ> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<CriarContaPJ> context)
        {
            _logger.LogInformation("Consumindo criar conta PJ");
            
            if (context.Message.Cpf == "1")
            {
                _logger.LogInformation("Falhou ao tentar cadastrar conta PJ");
                return context.Publish<ICriacaoContaPJFalhou>(new {
                    context.Message.IdConta
                });
            }

            return context.Publish<IContaPJCriada>(new
            {
                context.Message.IdConta,
                context.Message.Cpf
            });

        }
    }
}

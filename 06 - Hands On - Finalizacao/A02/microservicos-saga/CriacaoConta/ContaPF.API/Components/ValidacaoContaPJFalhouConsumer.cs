using ContaPF.API.Events;
using ContaPJ.API.Events;
using MassTransit;

namespace ContaPJ.API.Components
{
    public class ValidacaoContaPJFalhouConsumer : IConsumer<IValidacaoFalhou>
    {
        private readonly ILogger<IValidacaoFalhou> _logger;

        public ValidacaoContaPJFalhouConsumer(ILogger<IValidacaoFalhou> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<IValidacaoFalhou> context)
        {
            _logger.LogInformation("Criação da conta PJ falou  {@Message}", context.Message);

            // Para o Saga funcionar, precisamos reverter todos os eventos que acançaram
            return context.Publish<ICriacaoContaPJFalhou>(new
            {
                context.Message.IdConta,
            });
        }
    }
}

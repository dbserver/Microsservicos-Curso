using ContaPF.API.Events;
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
            return Task.CompletedTask;
        }
    }
}

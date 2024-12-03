using ContaPJ.API.Events;
using MassTransit;

namespace ContaPJ.API.Components
{
    public class CriacaoContaPJFalhouConsumer : IConsumer<ICriacaoContaPJFalhou>
    {
        private readonly ILogger<ICriacaoContaPJFalhou> _logger;

        public CriacaoContaPJFalhouConsumer(ILogger<ICriacaoContaPJFalhou> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<ICriacaoContaPJFalhou> context)
        {
            _logger.LogInformation("Criação da conta PJ falou  {@Message}", context.Message);
            return Task.CompletedTask;
        }
    }
}

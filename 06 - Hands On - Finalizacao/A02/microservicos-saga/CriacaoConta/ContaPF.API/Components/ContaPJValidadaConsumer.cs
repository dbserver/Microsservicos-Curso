using ContaPF.API.Events;
using MassTransit;

namespace ContaPJ.API.Components
{
    public class ContaPJValidadaConsumer : IConsumer<IValidacaoOcorrida>
    {
        private readonly ILogger<IValidacaoOcorrida> _logger;

        public ContaPJValidadaConsumer(ILogger<IValidacaoOcorrida> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<IValidacaoOcorrida> context)
        {
            _logger.LogInformation("ContaPJ validada com sucesso {@Message}", context.Message);
            return Task.CompletedTask;
        }
    }
}

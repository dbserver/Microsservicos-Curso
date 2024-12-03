using ContaPJ.API.Events;
using MassTransit;

namespace ContaPJ.API.Components
{
    public class ContaPJCriadaConsumer : IConsumer<IContaPJCriada>
    {
        private readonly ILogger<IContaPJCriada> _logger;

        public ContaPJCriadaConsumer(ILogger<IContaPJCriada> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<IContaPJCriada> context)
        {
            _logger.LogInformation("ContaPJ Criada com sucesso {@Message}", context.Message);
            return Task.CompletedTask;
        }
    }

    public class ContaPJCriadaConsumerDefinition : ConsumerDefinition<ContaPJCriadaConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator,
        IConsumerConfigurator<ContaPJCriadaConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Immediate(10));
        }
    }
}

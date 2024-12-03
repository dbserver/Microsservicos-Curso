using MassTransit;
using NotificadorCriacaoConta.API.Events;

namespace ContaPJ.API.Components
{
    public class CriacaoContaNotificadaConsumer : IConsumer<ICriacaoContaNotificada>
    {
        private readonly ILogger<ICriacaoContaNotificada> _logger;

        public CriacaoContaNotificadaConsumer(ILogger<ICriacaoContaNotificada> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<ICriacaoContaNotificada> context)
        {
            _logger.LogInformation("Criação da ContaPJ notificada com sucesso {@Message}", context.Message);
            return Task.CompletedTask;
        }
    }
}

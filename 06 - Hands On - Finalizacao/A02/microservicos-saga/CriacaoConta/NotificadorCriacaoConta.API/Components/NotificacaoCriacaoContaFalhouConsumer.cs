using MassTransit;
using NotificadorCriacaoConta.API.Events;

namespace ContaPJ.API.Components
{
    public class NotificacaoCriacaoContaFalhouConsumer : IConsumer<INotificacaoCriacaoContaFalhou>
    {
        private readonly ILogger<INotificacaoCriacaoContaFalhou> _logger;

        public NotificacaoCriacaoContaFalhouConsumer(ILogger<INotificacaoCriacaoContaFalhou> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<INotificacaoCriacaoContaFalhou> context)
        {
            _logger.LogInformation("Notificação da criação da conta PJ falou  {@Message}", context.Message);
            return Task.CompletedTask;
        }
    }
}

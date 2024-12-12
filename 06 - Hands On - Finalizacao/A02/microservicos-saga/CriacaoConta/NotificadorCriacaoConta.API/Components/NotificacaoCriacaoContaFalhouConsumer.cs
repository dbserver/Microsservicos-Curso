using ContaPF.API.Events;
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

            // Para o Saga funcionar, precisamos reverter todos os eventos que acançaram
            return context.Publish<IValidacaoFalhou>(new
            {
                context.Message.IdConta,
            });

        }
    }
}

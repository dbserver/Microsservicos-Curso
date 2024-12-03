using MassTransit;
using NotificadorCriacaoConta.API.Commands;
using NotificadorCriacaoConta.API.Events;

namespace ContaPJ.API.Components
{
    public class NotificarCadastroConsumer : IConsumer<NotificarCadastro>
    {
        private readonly ILogger<NotificarCadastro> _logger;

        public NotificarCadastroConsumer(ILogger<NotificarCadastro> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<NotificarCadastro> context)
        {
            _logger.LogInformation("Consumindo notificacao conta PJ");
            
            if (context.Message.Cpf == "3")
            {
                _logger.LogInformation("Falhou ao tentar notificar criação conta PJ");
                return context.Publish<INotificacaoCriacaoContaFalhou>(new {
                    context.Message.IdConta
                });
            }

            return context.Publish<ICriacaoContaNotificada>(new
            {
                context.Message.IdConta,
                context.Message.Cpf
            });

        }
    }
}

using ContaPF.API.Commands;
using ContaPF.API.Events;
using MassTransit;

namespace ContaPJ.API.Components
{
    public class ValidadorContaPJConsumer : IConsumer<ValidadorContaPJ>
    {
        private readonly ILogger<ValidadorContaPJ> _logger;

        public ValidadorContaPJConsumer(ILogger<ValidadorContaPJ> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<ValidadorContaPJ> context)
        {
            _logger.LogInformation("Validando criar conta PJ");
            
            if (context.Message.Cpf == "2")
            {
                _logger.LogInformation("Falhou ao tentar validar conta PJ");
                return context.Publish<IValidacaoFalhou>(new {
                    context.Message.IdConta
                });
            }

            return context.Publish<IValidacaoOcorrida>(new
            {
                context.Message.IdConta,
                context.Message.Cpf
            });

        }
    }
}

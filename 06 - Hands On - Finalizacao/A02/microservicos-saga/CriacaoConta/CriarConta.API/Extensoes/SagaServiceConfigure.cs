using CriarConta.API.Components;
using CriarConta.API.Contracts;
using MassTransit;

namespace CriarConta.API.Extensoes
{
    public static class ServicesExtensions
    {
        public static void AddMassTransitService(this IServiceCollection services)
        {

            

            services.AddMassTransit(x =>
            {
                x.AddSagaStateMachine<SolicitacaoContaStateMachine, SolicitacaoContaState>()
                    .InMemoryRepository();

                x.UsingRabbitMq((context, cfg) =>
                {

                    cfg.ReceiveEndpoint("solicitar-conta", e =>
                    {
                        e.UseMessageRetry(r => r.Immediate(50));
                       e.StateMachineSaga<SolicitacaoContaState>(context);
                    });
                });
            });
        }
    }
}


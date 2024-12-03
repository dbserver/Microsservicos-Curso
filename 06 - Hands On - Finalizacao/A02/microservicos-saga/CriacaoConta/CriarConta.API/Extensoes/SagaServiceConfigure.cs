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

                x.AddSaga<ContaPJSolicitada>();

                // A Transport
                x.UsingRabbitMq((context, cfg) =>
                {
                    //x.AddSagaStateMachine<SolicitacaoContaStateMachine, SolicitacaoContaState>()
                    //           .InMemoryRepository();
                    cfg.ReceiveEndpoint("solicitar-conta", e =>
                    {
                        e.UseMessageRetry(r => r.Immediate(50));
                       // e.StateMachineSaga<SolicitacaoContaState>(context);
                    });
                });
            });
        }
    }
}


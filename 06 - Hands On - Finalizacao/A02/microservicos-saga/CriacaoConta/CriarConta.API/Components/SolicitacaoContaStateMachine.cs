using ContaPF.API.Commands;
using ContaPF.API.Events;
using ContaPJ.API.Commands;
using ContaPJ.API.Events;
using CriarConta.API.Contracts;
using MassTransit;
using NotificadorCriacaoConta.API.Commands;
using NotificadorCriacaoConta.API.Events;

namespace CriarConta.API.Components
{
    public class SolicitacaoContaStateMachine : MassTransitStateMachine<SolicitacaoContaState>
    {
        // Eventos do SAGA
        public Event<ContaPJSolicitada> ContaPJSolicitada { get; set; }
        public Event<IContaPJCriada> ContaPJCriada { get; set; }
        public Event<IValidacaoOcorrida> ValidacaoOcorrida { get; set; }
        public Event<ICriacaoContaNotificada> CriacaoContaNotificada { get; set; }

        // Estados do SAGA
        public State CriacaoContaPJSolicitada { get; set; }
        public State ValidacaoSolicitada { get; set; }
        public State NotificacaoSolicitada { get; set; }

        public SolicitacaoContaStateMachine()
        {
            InstanceState(x => x.CurrentState);

            // Inicialização do estados do SAGA
            Event(() => ContaPJSolicitada, context => context.CorrelateById(m => m.Message.IdConta));
            Event(() => ContaPJCriada, context => context.CorrelateById(m => m.Message.IdConta));
            Event(() => ValidacaoOcorrida, context => context.CorrelateById(m => m.Message.IdConta));

            // Inicialização do saga
            Initially(
                When(ContaPJSolicitada)
                .Then(context =>
                {
                    context.Saga.CorrelationId = context.Message.IdConta;
                    context.Saga.Cpf = context.Message.CriarContaPJ.Cpf;
                })
                .SendAsync(new Uri("queue:criar-conta"), context => context.Init<CriarContaPJ>(new
                {
                    IdConta = context.Saga.CorrelationId,
                    context.Message.CriarContaPJ.Cpf,
                    context.Message.CriarContaPJ.Cnpj,
                }))
                .TransitionTo(CriacaoContaPJSolicitada)
            );

            During(CriacaoContaPJSolicitada,
                When(ContaPJCriada)
                    .SendAsync(new Uri("queue:validador-conta-pj"), context => context.Init<ValidadorContaPJ>(new
                    {
                        IdConta = context.Saga.CorrelationId,
                        context.Message.Cpf,
                    }))
                    .TransitionTo(ValidacaoSolicitada)
            );

            During(ValidacaoSolicitada,
                When(ValidacaoOcorrida)
                    .SendAsync(new Uri("queue:notificar-cadastro"), context => context.Init<NotificarCadastro>(new
                    {
                        IdConta = context.Saga.CorrelationId,
                        context.Message.Cpf,
                    }))
                    .TransitionTo(NotificacaoSolicitada)
            );

            During(NotificacaoSolicitada, 
                When(CriacaoContaNotificada)
                .Then(_ => Console.WriteLine("Conta cadastrada"))
                .Finalize()
            );

        }
    }

    public class SolicitacaoContaState : SagaStateMachineInstance
    {
        public Guid CorrelationId { get; set; }
        public string CurrentState { get; set; }
        public string Cpf { get; set; }
    }
}

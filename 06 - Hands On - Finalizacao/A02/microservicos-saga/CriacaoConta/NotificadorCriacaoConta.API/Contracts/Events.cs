namespace NotificadorCriacaoConta.API.Events
{
    public interface ICriacaoContaNotificada
    {
        public Guid IdConta { get; set; }
    }

    public interface INotificacaoCriacaoContaFalhou
    {
        public Guid IdConta { get; set; }
    }
}

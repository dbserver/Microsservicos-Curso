namespace ContaPJ.API.Events
{
    public interface IContaPJCriada
    {
        public Guid IdConta { get; set; }
        public string Cpf { get; set; }
    }

    public interface ICriacaoContaPJFalhou
    {
        public Guid IdConta { get; set; }
    }
}

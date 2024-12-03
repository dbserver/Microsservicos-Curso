namespace ContaPF.API.Events
{
    public interface IValidacaoOcorrida
    {
        public Guid IdConta { get; set; }
        public string Cpf { get; set; }
    }

    public interface IValidacaoFalhou
    {
        public Guid IdConta { get; set; }
    }
}

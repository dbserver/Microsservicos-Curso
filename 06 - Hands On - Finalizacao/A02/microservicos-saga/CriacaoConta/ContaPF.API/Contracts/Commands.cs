namespace ContaPF.API.Commands
{
    public class ValidadorContaPJ
    {
        public Guid IdConta { get; set; }
        public required string Cpf { get; set; }
    }
}

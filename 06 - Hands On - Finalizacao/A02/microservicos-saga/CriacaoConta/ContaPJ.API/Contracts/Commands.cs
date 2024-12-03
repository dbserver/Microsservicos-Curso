namespace ContaPJ.API.Commands
{
    public class CriarContaPJ
    {
        public Guid IdConta { get; set; }
        public required string Cpf { get; set; }
        public required string Cnpj { get; set; }
    }
}

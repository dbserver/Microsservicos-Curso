namespace NotificadorCriacaoConta.API.Commands
{
    public class NotificarCadastro
    {
        public Guid IdConta { get; set; }
        public required string Cpf { get; set; }
    }
}

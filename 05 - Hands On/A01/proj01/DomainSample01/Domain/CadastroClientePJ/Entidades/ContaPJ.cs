using Domain.Dtos;

namespace Domain.CadastroClientePJ.Entidades
{
    public class ContaPJ : IRaizDeAgregacao
    {
		private string agencia;
        private string Cnpj;
		private string matriculaGerente;
		private DateTime dataAbertura;
		private List<ClientePJ> clientes = new List<ClientePJ>();

        public ContaPJ(CriadorContaPJ criadorConta)
        {
            // Validações

            agencia = criadorConta.Agencia;
            matriculaGerente = criadorConta.MatriculaGerente;
            Cnpj = criadorConta.CNPJ;
            dataAbertura = DateTime.Now;
        }

        public void AdicionarTitular(CriadorContaPF criadorConta)
        {
            var titular = new ClientePJ(criadorConta);
            titular.IdentificarAdministrador();

            clientes.Add(titular);
        }
    }
}

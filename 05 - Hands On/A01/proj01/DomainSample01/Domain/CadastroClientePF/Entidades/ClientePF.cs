using Domain.Commons.Enuns;
using Domain.Dtos;

namespace Domain.CadastroClientePF.Entidades
{
    public class ClientePF
    {
		private string cpf;
		private string nome;
		private string nomeMae;
		private TipoClientePF tipoCliente;
		private EnderecoPF endereco;
		private ContatoPf contato;

        public ClientePF(CriadorContaPF criadorConta)
        {
            // Validações

            cpf = criadorConta.Cpf;
            nome = criadorConta.Nome;
            nomeMae = criadorConta.NomeMae;
            endereco = new EnderecoPF(criadorConta.Cep, criadorConta.Endereco, criadorConta.Numero, criadorConta.Cidade, criadorConta.Estado);
            contato = new ContatoPf(criadorConta.Telefone, (TipoTelefone)criadorConta.TipoTelefone);
        }

        public void IdentificarTitular()
        {
            this.tipoCliente = TipoClientePF.Titular;
        }
    }
}

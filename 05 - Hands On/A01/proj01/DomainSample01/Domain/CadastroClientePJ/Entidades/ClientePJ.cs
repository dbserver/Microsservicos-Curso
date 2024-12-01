using Domain.CadastroClientePF.Entidades;
using Domain.Commons.Enuns;
using Domain.Dtos;

namespace Domain.CadastroClientePJ.Entidades
{
    public class ClientePJ
    {
		private string cpf;
		private string nome;
		private string nomeMae;
		private TipoClientePJ tipoCliente;
		private EnderecoPJ endereco;
		private ContatoPJ contato;

        public ClientePJ(CriadorContaPF criadorConta)
        {
            // Validações

            cpf = criadorConta.Cpf;
            nome = criadorConta.Nome;
            nomeMae = criadorConta.NomeMae;
            endereco = new EnderecoPJ(criadorConta.Cep, criadorConta.Endereco, criadorConta.Numero, criadorConta.Cidade, criadorConta.Estado);
            contato = new ContatoPJ(criadorConta.Telefone, (TipoTelefone)criadorConta.TipoTelefone);
        }

        public void IdentificarAdministrador()
        {
            this.tipoCliente = TipoClientePJ.Administrador;
        }
    }
}

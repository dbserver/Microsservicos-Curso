using Domain.Commons.Enuns;
using Domain.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public string Cpf { get => cpf; }
        public string Nome { get => nome; }
        public string NomeMae { get => nomeMae; }
        public string Cep { get => endereco.Cep; }
        public string Endereco { get => endereco.Endereco; }
        public string Numero { get => endereco.Numero; }
        public string Cidade { get => endereco.Cidade; }
        public string Estado { get => endereco.Estado; }
        public string Telefone { get => contato.Numero; }
        public TipoTelefone TipoTelefone { get => contato.Tipo; }

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

        public bool IsTitular()
        {
            return this.tipoCliente == TipoClientePF.Titular;
        }
    }
}

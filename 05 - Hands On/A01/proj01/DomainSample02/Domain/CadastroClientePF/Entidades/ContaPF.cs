using Domain.Dtos;
using Domain.Repository;

namespace Domain.CadastroClientePF.Entidades
{
    public class ContaPF : IRaizDeAgregacao
    {
        private string agencia;
        private string matriculaGerente;
        private DateTime dataAbertura;
        private List<ClientePF> clientes = new List<ClientePF>();

        public string Agencia { get { return agencia; } }
        public string Matricula { get { return matriculaGerente; } }
        public DateTime DataAberturaConta { get { return dataAbertura; } }
        private ClientePF Titular { get { return clientes.First(x => x.IsTitular()); } }

        

        public ContaPF(CriadorContaPF criadorConta)
        {
            // Validações

            agencia = criadorConta.Agencia;
            matriculaGerente = criadorConta.MatriculaGerente;
            dataAbertura = DateTime.Now;
            AdicionarTitular(criadorConta);
        }

        public void AdicionarTitular(CriadorContaPF criadorConta)
        {
            var titular = new ClientePF(criadorConta);
            titular.IdentificarTitular();

            clientes.Add(titular);
        }

        public PersistirContaPF DadosConta()
        {
            var titular = this.Titular;

            return new PersistirContaPF()
            {
                Agencia = agencia,
                Cep = titular.Cep,
                Cidade = titular.Cidade,
                Cpf = titular.Cpf,
                Endereco = titular.Endereco,
                Estado = titular.Estado,
                MatriculaGerente = matriculaGerente,
                Nome = titular.Nome,
                NomeMae = titular.NomeMae,
                Numero = titular.Numero,
                Telefone = titular.Telefone,
                TipoTelefone = (int)titular.TipoTelefone,
                DataAberturaConta = dataAbertura
            };
        }
    }
}

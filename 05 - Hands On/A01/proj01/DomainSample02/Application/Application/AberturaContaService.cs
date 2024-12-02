using Application.Interface;
using Domain.CadastroClientePF.Entidades;
using Domain.CadastroClientePF.Repository;
using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application
{
    public class AberturaContaService : IAberturaContaService
    {
        private readonly ICadastroClientePFRepository cadastroClientePFRepository;

        public AberturaContaService(ICadastroClientePFRepository cadastroClientePFRepository)
        {
            this.cadastroClientePFRepository = cadastroClientePFRepository;
        }

        public async void CriarConta()
        {
            var criador = new CriadorContaPF()
            {
                Agencia = "1234",
                Cep = "92022258",
                Cidade = "Porto Alegre",
                Cpf = "11111111111",
                Endereco = "Rua XPTO",
                Estado = "Rio Grando do Sul",
                MatriculaGerente = "123",
                Nome = "Nome cliente",
                NomeMae = "Nome mãe Cliente",
                Numero = "123",
                Telefone = "+5551996587412",
                TipoTelefone = 0
            };

            var conta = new ContaPF(criador);
            cadastroClientePFRepository.NovoCadastroConta(conta);
        }
    }
}

using ContratosNuget.Rest;
using Domain.CadastroClientePF.Entidades;
using Domain.CadastroClientePF.Repository;
using System.Text;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class CadastroClientePFRepository : ICadastroClientePFRepository
    {
        public async Task NovoCadastroConta(ContaPF conta)
        {
            try
            {
                var dados = conta.DadosConta();

                var cliente = new ClienteDto()
                {
                    Agencia = Int16.Parse(dados.Agencia),
                    CodCliente = dados.Cpf,
                    CodOperador = dados.MatriculaGerente,
                    DtAbeCad = dados.DataAberturaConta,
                    NomeCliente = dados.Nome,
                    NomeMae = dados.NomeMae,
                    TipoPessoa = "F",
                    
                };

                using (HttpClient httpClient = new HttpClient())
                {
                    var message = JsonSerializer.Serialize(cliente);

                    var content = new StringContent(message,
                                        Encoding.UTF8,
                                        "application/json");

                    var response = await httpClient.PostAsync("http://localhost:5194/cliente", content);

                    var result = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }
        }
    }
}

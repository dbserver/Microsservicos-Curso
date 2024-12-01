using Domain.CadastroClientePF.Entidades;
using Domain.Repository;

namespace Domain.CadastroClientePF.Repository
{
    public interface ICadastroClientePFRepository : IRepository<ContaPF>
    {
        public void NovoCadastroConta(ContaPF conta);
    }
}

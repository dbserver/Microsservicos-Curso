using Domain.CadastroClientePJ.Entidades;
using Domain.Repository;

namespace Domain.CadastroClientePJ.Repository
{
    public interface ICadastroClientePJRepository : IRepository<ContaPJ>
    {
        public void NovoCadastroConta(ContaPJ conta);
    }
}

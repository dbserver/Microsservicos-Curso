using ContaPF.API.Commands;
using ContaPJ.API.Commands;

namespace CriarConta.API.Contracts
{
    public class ContaPJSolicitada
    {
        public Guid IdConta { get; set; }
        public required CriarContaPJ CriarContaPJ { get; set; }
        public required ValidadorContaPJ ValidadorContaPJ { get; set; }
    } 
}

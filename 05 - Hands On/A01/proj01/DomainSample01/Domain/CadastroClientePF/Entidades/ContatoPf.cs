using Domain.Commons.Enuns;

namespace Domain.CadastroClientePF.Entidades
{
    public class ContatoPf
    {
		private string numero;
		private TipoTelefone Tipo;

        public ContatoPf(string numero, TipoTelefone tipo)
        {
            this.numero = numero;
            Tipo = tipo;
        }
    }
}

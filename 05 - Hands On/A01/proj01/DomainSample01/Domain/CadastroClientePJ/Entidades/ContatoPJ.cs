using Domain.Commons.Enuns;

namespace Domain.CadastroClientePJ.Entidades
{
    public class ContatoPJ
    {
		private string numero;
		private TipoTelefone Tipo;

        public ContatoPJ(string numero, TipoTelefone tipo)
        {
            this.numero = numero;
            Tipo = tipo;
        }
    }
}

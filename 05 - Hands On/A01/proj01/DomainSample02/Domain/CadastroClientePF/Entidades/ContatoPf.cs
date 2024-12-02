using Domain.Commons.Enuns;

namespace Domain.CadastroClientePF.Entidades
{
    public class ContatoPf
    {
		private string numero;
		private TipoTelefone tipo;

        public ContatoPf(string numero, TipoTelefone tipo)
        {
            // Validações 
            this.numero = numero;
            tipo = tipo;
        }

        public string Numero { get => numero;  }
        public TipoTelefone Tipo { get => tipo;  }
    }
}

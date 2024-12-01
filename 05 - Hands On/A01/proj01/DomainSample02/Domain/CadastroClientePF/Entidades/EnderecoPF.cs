﻿namespace Domain.CadastroClientePF.Entidades
{
    public class EnderecoPF
    {
		private string cep;
		private string endereco;
		private string numero;
		private string cidade;
		private string estado;

        public EnderecoPF(string cep, string endereco, string numero, string cidade, string estado)
        {
            // Validações

            this.cep = cep;
            this.endereco = endereco;
            this.numero = numero;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}

namespace ContratosNuget.Rest
{
    public class ClienteDto
    {
        public string CodCliente { get; set; }
        public string TipoPessoa { get; set; }

        public Int16 Agencia { get; set; }

        public string CodOperador { get; set; }

        public DateTime DtAbeCad { get; set; }

        public string NomeCliente { get; set; }

        public DateTime? DtConstituicao { get; set; }
        public string? IndFunc { get; set; }
        public string? NomeFantasia { get; set; }

        public string NomeMae { get; set; }

        public string? VlrCapitalSocial { get; set; }
    }
}

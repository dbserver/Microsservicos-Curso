namespace Domain.Dtos
{
    public class PersistirContaPF
    {
        public string Agencia { get; set; }
        public string MatriculaGerente { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public int TipoTelefone { get; set; }
        public DateTime DataAberturaConta { get; set; }
    }
}

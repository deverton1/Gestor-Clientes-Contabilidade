namespace SLClientesAPI.ViewModel
{
    public class EmpresasViewModel
    {
        public int Id { get; set; }
        public required string RazaoSocial { get; set; }
        public required string Cnpj { get; set; }
        public required string NomeRepresentante { get; set; }
        public required string CpfRepresentante { get; set; }
        public required int CodigoSimplesnacio { get; set; }
        public required string Logradouro { get; set; }
        public required string Tributacao { get; set; }
        public required string Porte { get; set; }
        public required DateTime DataAbertura { get; set; }
    }
}

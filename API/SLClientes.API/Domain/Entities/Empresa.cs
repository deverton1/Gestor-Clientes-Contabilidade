using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public required int Id { get; set; }
        public required string RazaoSocial { get; set; }
        public required string Cnpj { get; set; }
        public required string NomeRepresentante { get; set; }
        public required string CpfRepresentante { get; set; }
        public required string CodigoSimplesNacio { get; set; }
        public required string Logradouro { get; set; }
        public required string Tributacao { get; set; }
        public required string Porte { get; set; }
        public DateTime DataAbertura { get; set; }
       // public bool Ativo { get; set; } = true;
    }
}

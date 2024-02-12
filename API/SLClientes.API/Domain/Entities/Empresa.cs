using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string NomeRepresentante { get; set; }
        public string CpfRepresentante { get; set; }
        public string CodigoSimplesNacio { get; set; }
        public string Logradouro { get; set; }
        public string Tributacao { get; set; }
        public string Porte { get; set; }
        public DateTime DataAbertura { get; set; }
       // public bool Ativo { get; set; } = true;
    }
}

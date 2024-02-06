using Microsoft.AspNetCore.Mvc;
using SLClientesAPI.Model;
using SLClientesAPI.ViewModel;

namespace SLClientesAPI.Controllers
{
    [ApiController]
    [Route("api/v1/empresas")]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresasRepository _empresasRepository;

        public EmpresasController(IEmpresasRepository empresasRepository)
        {
            _empresasRepository = empresasRepository ?? throw new ArgumentNullException(nameof(empresasRepository));
        }

        public IActionResult Add(EmpresasViewModel empresasView)
        {
            var empresa = new Empresas(empresasView.Id, empresasView.RazaoSocial, empresasView.NomeRepresentante, empresasView.CpfRepresentante, empresasView.CodigoSimplesnacio, empresasView.Logradouro, empresasView.Tributacao, empresasView.Porte, empresasView.DataAbertura);
            _empresasRepository.Add(empresa);
            return Ok();
        }
    }
}

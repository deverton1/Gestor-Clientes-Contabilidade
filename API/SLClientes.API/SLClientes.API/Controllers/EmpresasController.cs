using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SLClientes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresasService _empresasService;

        public EmpresasController(IEmpresasService empresasService)
        {
            _empresasService = empresasService;
        }
        [HttpPost]
        [Route("Cadastrar-Empresa")]
        public async Task<IActionResult> CadastrarEmpresa([FromBody] EmpresaCommand command)
        {
            return Ok(await _empresasService.CadastrarEmpresa(command));
        }
        [HttpPut]
        [Route("Atualizar-Empresa")]
        public async Task<IActionResult> AtualizarEmpresa(int empresaId, EmpresaCommand command)
        {
            return Ok(await _empresasService.AtualizarEmpresa(empresaId, command));
        }
        [HttpGet]
        [Route("Listar-Empresas")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _empresasService.GetAllAsync());
        }
    }
}

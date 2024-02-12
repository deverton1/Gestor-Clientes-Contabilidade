using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EmpresasServices : IEmpresasService
    {
        private readonly IEmpresasRepository _empresasRepository;
        public EmpresasServices(IEmpresasRepository empresasRepository)
        {
            _empresasRepository = empresasRepository;
        }

        public async Task<string> AtualizarEmpresa(int empresaId, EmpresaCommand command)
        {
            return await _empresasRepository.AtualizarEmpresa(empresaId, command);
        }

        public async Task<string> CadastrarEmpresa(EmpresaCommand command)
        {
            return await _empresasRepository.CadastrarEmpresa(command);
        }

        public async Task<IEnumerable<EmpresaCommand>> GetAllAsync()
        {
            return await _empresasRepository.GetAllAsync();
        }
    }
}

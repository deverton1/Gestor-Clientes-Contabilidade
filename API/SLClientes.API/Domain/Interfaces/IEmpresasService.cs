using Domain.Command;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEmpresasService
    {
        Task<IEnumerable<EmpresaCommand>> GetAllAsync();
        Task<string> CadastrarEmpresa(EmpresaCommand command);
        Task<string> AtualizarEmpresa(int empresaId, EmpresaCommand command);
    }
}

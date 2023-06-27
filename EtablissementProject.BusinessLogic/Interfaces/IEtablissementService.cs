using EtablissementProject.DataAccess.Dto;
using EtablissementProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.BusinessLogic.Interfaces
{
    public interface IEtablissementService
    {
        Task<Response> GetAllEtablissementAsync(string code);
        Task<IEnumerable<EtablissementDto>> GetNewAllEtablissementAsync(string code);
    }
}

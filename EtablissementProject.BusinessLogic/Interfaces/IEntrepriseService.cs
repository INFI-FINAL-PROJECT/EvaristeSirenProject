using EtablissementProject.DataAccess.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.BusinessLogic.Interfaces
{
    public interface IEntrepriseService
    {
        Task AddManyEntrepriseAsync(IEnumerable<EtablissementDto> etablissements);
    }
}

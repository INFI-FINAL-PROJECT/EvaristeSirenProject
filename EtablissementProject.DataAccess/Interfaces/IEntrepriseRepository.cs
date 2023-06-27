using EtablissementProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Interfaces
{
    public interface IEntrepriseRepository
    {
        Task AddManyEntrepriseAsync(Entreprise entreprise);
    }
}

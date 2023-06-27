using EtablissementProject.BusinessLogic.Interfaces;
using EtablissementProject.DataAccess.Dto;
using EtablissementProject.DataAccess.Interfaces;
using EtablissementProject.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.BusinessLogic.Services
{
    public class EntrepriseService : IEntrepriseService
    {
        private readonly IEntrepriseRepository _entrepriseRepository;

        public EntrepriseService(IEntrepriseRepository entrepriseRepository)
        {
            _entrepriseRepository = entrepriseRepository;
        }

        public async Task AddManyEntrepriseAsync(IEnumerable<EtablissementDto> etablissements)
        {

           foreach(var etablissement in etablissements)
            {
                Entreprise entrepr = new Entreprise();
                entrepr.Siret = etablissement.Siret;
                entrepr.Siren = etablissement.Siren;
                entrepr.NafCode = etablissement.ActivitePrincipaleUniteLegale;
                entrepr.Town = etablissement.LibelleCommuneEtablissement;
                entrepr.PostalCode = etablissement.CodePostalEtablissement;
                entrepr.Denomination = etablissement.Prenom1UniteLegale + etablissement.NomUniteLegale;
                entrepr.Address = etablissement.NumeroVoieEtablissement + etablissement.IndiceRepetitionEtablissement + etablissement.TypeVoieEtablissement + etablissement.LibelleVoieEtablissement + etablissement.LibelleCommuneEtablissement;
                entrepr.Registration = etablissement.DateCreationEtablissement;

                await _entrepriseRepository.AddManyEntrepriseAsync(entrepr);

            }


        }
    }
}

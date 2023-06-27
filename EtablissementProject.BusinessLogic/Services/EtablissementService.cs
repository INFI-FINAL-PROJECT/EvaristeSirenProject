using EtablissementProject.BusinessLogic.Interfaces;
using EtablissementProject.DataAccess.Dto;
using EtablissementProject.DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.BusinessLogic.Services
{
    public class EtablissementService : IEtablissementService
    {
        private const string BaseUrl = "https://api.insee.fr/entreprises/sirene/V3/siret?debut=56";
        private readonly HttpClient _httpClient;
        private readonly IEntrepriseService _entrepriseService;

        public EtablissementService(HttpClient httpClient, IEntrepriseService entrepriseService)
        {
            _httpClient = httpClient;
            _entrepriseService = entrepriseService;
        }

        public async Task<Response> GetAllEtablissementAsync(string code)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer 799acb30-0560-3826-a941-375cf6d0bd83");
            HttpResponseMessage response = await _httpClient.GetAsync($"https://api.insee.fr/entreprises/sirene/V3/siret?q=activitePrincipaleUniteLegale:{code}");

            response.EnsureSuccessStatusCode();

              

            var content = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<Response>(content);

            return data;
        }

        public async Task<IEnumerable<EtablissementDto>> GetNewAllEtablissementAsync(string code)
        {
            Response res = await GetAllEtablissementAsync(code);

            IEnumerable<EtablissementDto> etablissements = res.etablissements.Select(a => new EtablissementDto
                                                          {
                                                            Siren = a.siren,
                                                            Siret = a.siret,
                                                            DateCreationEtablissement = a.dateCreationEtablissement,
                                                            DenominationUniteLegale = a.uniteLegale.denominationUniteLegale,
                                                            ActivitePrincipaleUniteLegale = a.uniteLegale.activitePrincipaleUniteLegale,
                                                            SexeUniteLegale = a.uniteLegale.sexeUniteLegale,
                                                            NomUniteLegale = a.uniteLegale.nomUniteLegale,
                                                            Prenom1UniteLegale = a.uniteLegale.prenom1UniteLegale,
                                                            NumeroVoieEtablissement = a.adresseEtablissement.numeroVoieEtablissement,
                                                            IndiceRepetitionEtablissement = a.adresseEtablissement.indiceRepetitionEtablissement,
                                                            TypeVoieEtablissement = a.adresseEtablissement.typeVoieEtablissement,
                                                            LibelleVoieEtablissement = a.adresseEtablissement.libelleVoieEtablissement,
                                                            CodePostalEtablissement = a.adresseEtablissement.codeCedexEtablissement,
                                                            LibelleCommuneEtablissement = a.adresseEtablissement.libelleCommuneEtablissement

                                                          });

            await _entrepriseService.AddManyEntrepriseAsync(etablissements);

            return etablissements;
        }


    }
}

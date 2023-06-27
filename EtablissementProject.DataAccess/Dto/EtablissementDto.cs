using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Dto
{
    public class EtablissementDto
    {
        public string Siren { get; set; }
        public string Siret { get; set; }
        public string DateCreationEtablissement { get; set; }
        public string DenominationUniteLegale { get; set; }
        public string ActivitePrincipaleUniteLegale { get; set; }
        public string SexeUniteLegale { get; set; }
        public string NomUniteLegale { get; set; }
        public string Prenom1UniteLegale { get; set; }
        public string NumeroVoieEtablissement { get; set; }
        public string IndiceRepetitionEtablissement { get; set; }
        public string TypeVoieEtablissement { get; set; }
        public string LibelleVoieEtablissement { get; set; }
        public string CodePostalEtablissement { get; set; }
        public string LibelleCommuneEtablissement { get; set; }
    }
}

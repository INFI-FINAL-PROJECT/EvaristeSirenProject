using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Models
{
    public class PeriodeEtablissement
    {
        public string dateFin { get; set; }
        public string dateDebut { get; set; }
        public string etatAdministratifEtablissement { get; set; }
        public bool changementEtatAdministratifEtablissement { get; set; }
        public string enseigne1Etablissement { get; set; }
        public string enseigne2Etablissement { get; set; }
        public string enseigne3Etablissement { get; set; }
        public bool changementEnseigneEtablissement { get; set; }
        public string denominationUsuelleEtablissement { get; set; }
        public string changementDenominationUsuelleEtablissement { get; set; }
        public string activitePrincipaleEtablissement { get; set; }
        public string nomenclatureActivitePrincipaleEtablissement { get; set; }
        public bool changementActivitePrincipaleEtablissement { get; set; }
        public string caractereEmployeurEtablissement { get; set; }
        public bool changementCaractereEmployeurEtablissement { get; set; }
        
         
    }
}

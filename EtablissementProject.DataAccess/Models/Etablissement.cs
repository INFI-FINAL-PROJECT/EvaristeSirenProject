using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Models
{
    public class Etablissement
    {

        public float score { get; set; }
        public string siren { get; set; }
        public string nic { get; set; }
        public string siret { get; set; }
        public string statutDiffusionEtablissement { get; set; }
        public string dateCreationEtablissement { get; set; }
        public string trancheEffectifsEtablissement { get; set; }
        public string anneeEffectifsEtablissement { get; set; }
        public string activitePrincipaleRegistreMetiersEtablissement { get; set; }
        public string dateDernierTraitementEtablissement { get; set; }
        public bool etablissementSiege { get; set; }
        public int nombrePeriodesEtablissement { get; set; }

        public UniteLegale uniteLegale { get; set; }
        public AdresseEtablissement adresseEtablissement { get; set; }
        public Adresse2Etablissement adresse2Etablissement { get; set; }
        public PeriodeEtablissement[] periodesEtablissement { get; set; }
    }
    
}

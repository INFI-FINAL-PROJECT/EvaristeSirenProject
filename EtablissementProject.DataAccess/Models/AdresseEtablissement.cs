using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Models
{
    public class AdresseEtablissement
    {

        public string complementAdresseEtablissement { get; set; }
        public string numeroVoieEtablissement { get; set; }
        public string indiceRepetitionEtablissement { get; set; }
        public string typeVoieEtablissement { get; set; }
        public string libelleVoieEtablissement { get; set; }
        public string codePostalEtablissement { get; set; }
        public string libelleCommuneEtablissement { get; set; }
        public string libelleCommuneEtrangerEtablissement { get; set; }
        public string distributionSpecialeEtablissement { get; set; }
        public string codeCommuneEtablissement { get; set; }
        public string codeCedexEtablissement { get; set; }
        public string libelleCedexEtablissement { get; set; }
        public string codePaysEtrangerEtablissement { get; set; }
        public string libellePaysEtrangerEtablissement { get; set; }

    }
}

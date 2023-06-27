using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Models
{
    public class Adresse2Etablissement
    {
        public string complementAdresse2Etablissement { get; set; }
        public string numeroVoie2Etablissement { get; set; }
        public string indiceRepetition2Etablissement { get; set; }
        public string typeVoie2Etablissement { get; set; }
        public string libelleVoie2Etablissement { get; set; }
        public string codePostal2Etablissement { get; set; }
        public string libelleCommune2Etablissement { get; set; }
        public string libelleCommuneEtrange2Etablissement { get; set; }
        public string distributionSpeciale2Etablissement { get; set; }
        public string codeCommune2Etablissement { get; set; }
        public string codeCedex2Etablissement { get; set; }
        public string libelleCedex2Etablissement { get; set; }
        public string codePaysEtrangerEtablissement { get; set; }
        public string libellePaysEtranger2Etablissement { get; set; }
    }
}

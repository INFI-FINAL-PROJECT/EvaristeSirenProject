using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Models
{
    public class Header
    {
        public String statut { get; set; }
        public String message { get; set; }
        public int total { get; set; }
        public int debut { get; set; }
        public int nombre { get; set; }

    }

    public class Response
    {
        public Header header { get; set; }
        public List<Etablissement> etablissements { get; set; }

    }
}

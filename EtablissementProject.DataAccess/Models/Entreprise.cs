using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EtablissementProject.DataAccess.Models
{
    public class Entreprise
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("registration")]
        public string Registration  { get; set; }
        [BsonElement("denomination")]

        public string Denomination { get; set; }
        [BsonElement("address")]

        public string Address  { get; set; }
        [BsonElement("postalCode")]
        public string PostalCode { get; set; }
        [BsonElement("town")]
        public string Town { get; set; }
        [BsonElement("siren")]
        public string Siren { get; set; }
        [BsonElement("siret")]
        public string Siret { get; set; }
        [BsonElement("nafcode")]
        public string NafCode { get; set; }
    }
}

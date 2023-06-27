using EtablissementProject.DataAccess.Interfaces;
using EtablissementProject.DataAccess.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtablissementProject.DataAccess.Repositories
{
    public class EntrepriseRepository : IEntrepriseRepository
    {
        private readonly IMongoDatabase _database;

        public EntrepriseRepository(IMongoDatabase database)
        {

            _database = database;
        }

        public async Task AddManyEntrepriseAsync(Entreprise entreprise)
        
            => await _database.GetCollection<Entreprise>("entreprise").InsertOneAsync(entreprise);

        
    }
}

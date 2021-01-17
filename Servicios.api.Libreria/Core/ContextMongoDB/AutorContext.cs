using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Servicios.api.Libreria.Core.Entities;

namespace Servicios.api.Libreria.Core.ContextMongoDB
{
    public class AutorContext : IAutorContext
    {

        private readonly IMongoDatabase _db;
        public AutorContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<Autor> Autores => _db.GetCollection<Autor>("Autor");
    }
}

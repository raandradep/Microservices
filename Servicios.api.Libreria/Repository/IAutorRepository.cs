using Servicios.api.Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicios.api.Libreria.Repository
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAutores();
    }
}

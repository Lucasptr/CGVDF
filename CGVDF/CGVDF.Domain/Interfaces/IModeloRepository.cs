using CGVDF.Domain.Entities;
using System.Collections.Generic;

namespace CGVDF.Domain.Interfaces
{
    public interface IModeloRepository : IRepositoryBase<Modelo>
    {
        IEnumerable<Modelo> GetByName(string nome);
    }
}

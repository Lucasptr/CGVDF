using System.Collections.Generic;
using System.Linq;
using CGVDF.Domain.Entities;
using CGVDF.Domain.Interfaces;

namespace CGVDF.Infra.Data.Repositories
{
    public class ModeloRepository : RepositoryBase<Modelo>, IModeloRepository
    {
        public IEnumerable<Modelo> GetByName(string nome)
        {
            return Db.Modelos.Where(p => p.NomeModelo == nome);
        }
    }
}

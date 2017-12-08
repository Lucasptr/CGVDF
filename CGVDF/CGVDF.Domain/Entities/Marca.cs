using System.Collections.Generic;

namespace CGVDF.Domain.Entities
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Modelo> Modelos { get; set; }

    }
}

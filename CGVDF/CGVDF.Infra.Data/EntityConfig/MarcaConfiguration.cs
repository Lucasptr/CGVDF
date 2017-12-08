using CGVDF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CGVDF.Infra.Data.EntityConfig
{
    public class MarcaConfiguration : EntityTypeConfiguration<Marca>
    {
        public MarcaConfiguration()
        {
            HasKey(c => c.MarcaId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

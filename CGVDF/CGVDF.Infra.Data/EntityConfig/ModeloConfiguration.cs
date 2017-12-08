using CGVDF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CGVDF.Infra.Data.EntityConfig
{
    public class ModeloConfiguration : EntityTypeConfiguration<Modelo>
    {
        public ModeloConfiguration()
        {
            HasKey(c => c.ModeloId);

            Property(c => c.NomeModelo)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.NumeroPrefixo)
                .IsRequired();

            Property(c => c.Placa)
                .IsRequired()
                .HasMaxLength(7);

            Property(c => c.Chassi)
                .IsRequired()
                .HasMaxLength(17);

            Property(c => c.AnoFabricacao)
                .IsOptional();

            //Ver qual vai ser o tipo desta propriedade
            Property(c => c.Radio)
                .IsRequired();

            HasRequired(c => c.Marca)
                .WithMany()
                .HasForeignKey(c => c.MarcaId);
        }
    }
}

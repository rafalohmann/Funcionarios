using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class SexoConfiguration: EntityTypeConfiguration<Sexo>
    {
        public SexoConfiguration()
        {
            ToTable("Sexo");
            Property(g => g.SexoId).IsRequired().HasMaxLength(1);
            Property(g => g.Descricao).IsRequired().HasMaxLength(30);
        }
    }
}

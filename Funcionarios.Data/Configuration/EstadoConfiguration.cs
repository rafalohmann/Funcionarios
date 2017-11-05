using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class EstadoConfiguration: EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            ToTable("Estado");
            Property(g => g.EstadoId).IsRequired().HasMaxLength(2);
            Property(g => g.Nome).IsRequired().HasMaxLength(50);
        }
    }
}

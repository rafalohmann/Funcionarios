using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class EstadoCivilConfiguration: EntityTypeConfiguration<EstadoCivil>
    {
        public EstadoCivilConfiguration()
        {
            ToTable("EstadoCivil");
            Property(g => g.EstadoCivilId).IsRequired();
            Property(g => g.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}

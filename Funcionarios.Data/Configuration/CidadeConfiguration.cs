using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class CidadeConfiguration: EntityTypeConfiguration<Cidade>
    {
        public CidadeConfiguration()
        {
            ToTable("Cidade");
            Property(g => g.CidadeId).IsRequired();
            Property(g => g.EstadoId).IsRequired().HasMaxLength(2);
            Property(g => g.Nome).IsRequired().HasMaxLength(50);
        }
    }
}

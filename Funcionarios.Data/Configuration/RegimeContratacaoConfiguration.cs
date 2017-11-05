using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class RegimeContratacaoConfiguration: EntityTypeConfiguration<RegimeContratacao>
    {
        public RegimeContratacaoConfiguration()
        {
            ToTable("RegimeContratacao");
            Property(g => g.RegimeContratacaoId).IsRequired();
            Property(g => g.Nome).IsRequired().HasMaxLength(50);
        }
    }
}

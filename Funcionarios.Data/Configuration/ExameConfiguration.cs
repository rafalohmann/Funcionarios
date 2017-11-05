using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class ExameConfiguration: EntityTypeConfiguration<Exame>
    {
        public ExameConfiguration()
        {
            ToTable("Exame");
            Property(g => g.ExameId).IsRequired();
            Property(g => g.Nome).IsRequired().HasMaxLength(50);
        }
    }
}

using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class EscolaridadeConfiguration: EntityTypeConfiguration<Escolaridade>
    {
        public EscolaridadeConfiguration()
        {
            ToTable("Escolaridade");
            Property(g => g.EscolaridadeId).IsRequired();
            Property(g => g.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}

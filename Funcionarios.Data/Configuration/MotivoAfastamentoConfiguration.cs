using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class MotivoAfastamentoConfiguration: EntityTypeConfiguration<MotivoAfastamento>
    {
        public MotivoAfastamentoConfiguration()
        {
            ToTable("MotivoAfastamento");
            Property(g => g.MotivoAfastamentoId).IsRequired();
            Property(g => g.Nome).IsRequired().HasMaxLength(30);
            Property(g => g.Descricao).HasMaxLength(255);
        }
    }
}

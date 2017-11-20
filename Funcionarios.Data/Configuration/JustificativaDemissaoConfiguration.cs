using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class JustificativaDemissaoConfiguration: EntityTypeConfiguration<JustificativaDemissao>
    {
        public JustificativaDemissaoConfiguration()
        {
            ToTable("JustificativaDemissao");
            Property(g => g.JustificativaDemissaoId).IsRequired();
            Property(g => g.Descricao).HasMaxLength(255);
        }
    }
}

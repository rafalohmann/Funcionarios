using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class ResultadoExameConfiguration: EntityTypeConfiguration<ResultadoExame>
    {
        public ResultadoExameConfiguration()
        {
            ToTable("ResultadoExame");
            Property(g => g.ResultadoExameId).IsRequired();
            Property(g => g.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}

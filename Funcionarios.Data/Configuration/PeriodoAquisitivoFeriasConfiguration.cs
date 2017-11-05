using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class PeriodoAquisitivoFeriasConfiguration: EntityTypeConfiguration<PeriodoAquisitivoFerias>
    {
        public PeriodoAquisitivoFeriasConfiguration()
        {
            ToTable("PeriodoAquisitivoFerias");
            Property(g => g.PeriodoAquisitivoFeriasId).IsRequired();
            Property(g => g.FuncionarioId).IsRequired();
            Property(g => g.DataInicial).IsRequired();
            Property(g => g.DataFinal).IsRequired();
            Property(g => g.Saldo).IsRequired();
        }
    }
}

using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class FeriasConfiguration: EntityTypeConfiguration<Ferias>
    {
        public FeriasConfiguration()
        {
            ToTable("Ferias");
            Property(g => g.FeriasId).IsRequired();
            Property(g => g.FuncionarioId).IsRequired();
            //Property(g => g.PeriodoAquisitivoFeriasId).IsRequired();
            Property(g => g.DataInicial).IsRequired();
            Property(g => g.DataFinal).IsRequired();
            Property(g => g.Descricao).HasMaxLength(255);
        }
    }
}

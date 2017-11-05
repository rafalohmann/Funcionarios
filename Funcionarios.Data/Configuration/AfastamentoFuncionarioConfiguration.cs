using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class AfastamentoFuncionarioConfiguration : EntityTypeConfiguration<AfastamentoFuncionario>
    {
        public AfastamentoFuncionarioConfiguration()
        {
            ToTable("AfastamentoFuncionario");
            Property(g => g.AfastamentoFuncionarioId).IsRequired();
            Property(g => g.FuncionarioId).IsRequired();
            Property(g => g.MotivoAfastamentoId).IsRequired();
            Property(g => g.DataInicial).IsRequired();
            Property(g => g.DataFinal).IsRequired();
            Property(g => g.Descricao).IsRequired().HasMaxLength(500);
        }
    }
}

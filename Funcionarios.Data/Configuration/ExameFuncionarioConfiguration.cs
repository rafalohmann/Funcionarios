using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class ExameFuncionarioConfiguration: EntityTypeConfiguration<ExameFuncionario>
    {
        public ExameFuncionarioConfiguration()
        {
            ToTable("ExameFuncionario");
            Property(g => g.ExameFuncionarioId).IsRequired();
            Property(g => g.FuncionarioId).IsRequired();
            Property(g => g.ExameId).IsRequired();
            Property(g => g.ResultadoExameId).IsRequired();
            Property(g => g.DataExame).IsRequired();
            Property(g => g.Observacao).HasMaxLength(255);
        }
    }
}

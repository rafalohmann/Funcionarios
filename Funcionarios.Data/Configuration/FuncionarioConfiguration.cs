using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class FuncionarioConfiguration: EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            ToTable("Funcionario");
            Property(g => g.FuncionarioId).IsRequired();
            Property(g => g.Nome).IsRequired().HasMaxLength(150);
            Property(g => g.DataAdmissao).IsRequired();
            Property(g => g.CPF).IsRequired();
            Property(g => g.RG).IsRequired();
            Property(g => g.OrgaoEmissorRG).IsRequired().HasMaxLength(10);
            Property(g => g.EstadoEmissorRGId).IsRequired().HasMaxLength(2);
            Property(g => g.DataEmissaoRG).IsRequired();
            Property(g => g.SexoId).IsRequired().HasMaxLength(50);
            Property(g => g.EstadoCivilId).IsRequired();
            Property(g => g.EscolaridadeId).IsRequired().HasMaxLength(50);
            Property(g => g.DataNascimento).IsRequired();

            Property(g => g.CarteiraTrabalho).IsRequired();
            Property(g => g.SerieCarteiraTrabalho).IsRequired();
            Property(g => g.LocalCarteiraTrabalho).IsRequired().HasMaxLength(50);
            Property(g => g.EstadoCarteiraTrabalhoId).IsRequired().HasMaxLength(2);
            Property(g => g.DataEmissaoCarteiraTrabalho).IsRequired();

            Property(g => g.CargoId).IsRequired();
            Property(g => g.CargaHoraria).IsRequired();
            Property(g => g.RegimeContratacaoId).IsRequired();

            Property(g => g.RelatorioDesligamento).HasMaxLength(500);

            Property(g => g.EstadoId).IsRequired().HasMaxLength(2);
            Property(g => g.CidadeId).IsRequired();
            Property(g => g.Endereco).HasMaxLength(200);
            Property(g => g.Bairro).HasMaxLength(150);
            Property(g => g.Telefone).HasMaxLength(30);
            Property(g => g.Celular).HasMaxLength(30);
            Property(g => g.Email).HasMaxLength(100);
        }
    }
}

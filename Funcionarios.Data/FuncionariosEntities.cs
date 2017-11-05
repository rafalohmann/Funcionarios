using Funcionarios.Data.Configuration;
using Funcionarios.Domain.Entities;
using System.Data.Entity;

namespace Funcionarios.Data
{
    public class FuncionariosEntities : DbContext
    {
        public FuncionariosEntities() : base("FuncionariosEntities") { }

        public DbSet<AfastamentoFuncionario> AfastamentoFuncionario { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Exame> Exame { get; set; }
        public DbSet<ExameFuncionario> ExameFuncionario { get; set; }
        public DbSet<Ferias> Ferias { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<JustificativaDemissao> JustificativaDemissao { get; set; }
        public DbSet<MotivoAfastamento> MotivoAfastamento { get; set; }
        public DbSet<PeriodoAquisitivoFerias> PeriodoAquisitivoFerias { get; set; }
        public DbSet<RegimeContratacao> RegimeContratacao { get; set; }
        public DbSet<ResultadoExame> ResultadoExame { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AfastamentoFuncionarioConfiguration());
            modelBuilder.Configurations.Add(new CargoConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new EscolaridadeConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new EstadoCivilConfiguration());
            modelBuilder.Configurations.Add(new ExameConfiguration());
            modelBuilder.Configurations.Add(new ExameFuncionarioConfiguration());
            modelBuilder.Configurations.Add(new FeriasConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new JustificativaDemissaoConfiguration());
            modelBuilder.Configurations.Add(new MotivoAfastamentoConfiguration());
            modelBuilder.Configurations.Add(new PeriodoAquisitivoFeriasConfiguration());
            modelBuilder.Configurations.Add(new RegimeContratacaoConfiguration());
            modelBuilder.Configurations.Add(new ResultadoExameConfiguration());
            modelBuilder.Configurations.Add(new SexoConfiguration());
        }
    }
}

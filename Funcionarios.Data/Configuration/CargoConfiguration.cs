using Funcionarios.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Funcionarios.Data.Configuration
{
    class CargoConfiguration: EntityTypeConfiguration<Cargo>
    {
        public CargoConfiguration()
        {
            ToTable("Cargo");
            Property(g => g.CargoId).IsRequired();
            Property(g => g.Nome).IsRequired().HasMaxLength(50);
            Property(g => g.Descricao).IsRequired().HasMaxLength(255);
        }
    }
}

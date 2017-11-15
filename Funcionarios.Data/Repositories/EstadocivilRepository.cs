            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class EstadoCivilRepository : BaseRepository<EstadoCivil>, IEstadoCivilRepository
    {
        public EstadoCivilRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IEstadoCivilRepository : IRepository<EstadoCivil>
    {

    }
}

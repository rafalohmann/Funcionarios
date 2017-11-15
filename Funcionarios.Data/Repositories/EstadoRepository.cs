            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class EstadoRepository : BaseRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IEstadoRepository : IRepository<Estado>
    {

    }
}

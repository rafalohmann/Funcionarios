            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class CargoRepository : BaseRepository<Cargo>, ICargoRepository
    {
        public CargoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ICargoRepository : IRepository<Cargo>
    {

    }
}

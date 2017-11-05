            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class CargoRepository : RepositoryBase<Cargo>, ICargoRepository
    {
        public CargoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ICargoRepository : IRepository<Cargo>
    {

    }
}

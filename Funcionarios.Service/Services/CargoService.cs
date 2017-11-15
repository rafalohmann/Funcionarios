                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class CargoService : BaseService<Cargo>, ICargoService
    {
        public CargoService(IRepository<Cargo> repository)
            : base(repository) { }
    }

    public interface ICargoService : IService<Cargo>
    {

    }
}

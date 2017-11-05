                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class CargoService : ServiceBase<Cargo>, ICargoService
    {
        public CargoService(RepositoryBase<Cargo> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface ICargoService : IService<Cargo>
    {

    }
}

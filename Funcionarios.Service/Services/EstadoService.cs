                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        public EstadoService(RepositoryBase<Estado> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IEstadoService : IService<Estado>
    {

    }
}

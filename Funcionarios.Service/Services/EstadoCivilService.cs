                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class EstadoCivilService : ServiceBase<EstadoCivil>, IEstadoCivilService
    {
        public EstadoCivilService(RepositoryBase<EstadoCivil> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IEstadoCivilService : IService<EstadoCivil>
    {

    }
}

                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class EstadoCivilService : BaseService<EstadoCivil>, IEstadoCivilService
    {
        public EstadoCivilService(IRepository<EstadoCivil> repository)
            : base(repository) { }
    }

    public interface IEstadoCivilService : IService<EstadoCivil>
    {

    }
}

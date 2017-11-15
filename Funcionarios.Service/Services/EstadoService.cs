                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class EstadoService : BaseService<Estado>, IEstadoService
    {
        public EstadoService(IRepository<Estado> repository)
            : base(repository) { }
    }

    public interface IEstadoService : IService<Estado>
    {

    }
}

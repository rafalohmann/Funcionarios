                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class FeriasService : BaseService<Ferias>, IFeriasService
    {
        public FeriasService(IRepository<Ferias> repository)
            : base(repository) { }
    }

    public interface IFeriasService : IService<Ferias>
    {

    }
}

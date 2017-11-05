                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class FeriasService : ServiceBase<Ferias>, IFeriasService
    {
        public FeriasService(RepositoryBase<Ferias> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IFeriasService : IService<Ferias>
    {

    }
}

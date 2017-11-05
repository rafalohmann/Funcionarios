                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class ExameService : ServiceBase<Exame>, IExameService
    {
        public ExameService(RepositoryBase<Exame> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IExameService : IService<Exame>
    {

    }
}

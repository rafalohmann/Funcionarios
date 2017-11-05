                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(RepositoryBase<Cidade> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface ICidadeService : IService<Cidade>
    {

    }
}

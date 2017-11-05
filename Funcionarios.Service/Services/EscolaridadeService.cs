
    
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class EscolaridadeService : ServiceBase<Escolaridade>, IEscolaridadeService
    {
        public EscolaridadeService(RepositoryBase<Escolaridade> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IEscolaridadeService : IService<Escolaridade>
    {

    }
}

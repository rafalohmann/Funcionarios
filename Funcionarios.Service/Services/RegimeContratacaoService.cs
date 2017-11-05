                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class RegimeContratacaoService : ServiceBase<RegimeContratacao>, IRegimeContratacaoService
    {
        public RegimeContratacaoService(RepositoryBase<RegimeContratacao> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IRegimeContratacaoService : IService<RegimeContratacao>
    {

    }
}

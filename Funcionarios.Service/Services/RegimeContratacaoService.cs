                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class RegimeContratacaoService : BaseService<RegimeContratacao>, IRegimeContratacaoService
    {
        public RegimeContratacaoService(IRepository<RegimeContratacao> repository)
            : base(repository) { }
    }

    public interface IRegimeContratacaoService : IService<RegimeContratacao>
    {

    }
}

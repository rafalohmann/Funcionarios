                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class CidadeService : BaseService<Cidade>, ICidadeService
    {
        public CidadeService(IRepository<Cidade> repository)
            : base(repository) { }
    }

    public interface ICidadeService : IService<Cidade>
    {

    }
}

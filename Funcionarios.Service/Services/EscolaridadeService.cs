
    
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class EscolaridadeService : BaseService<Escolaridade>, IEscolaridadeService
    {
        public EscolaridadeService(IRepository<Escolaridade> repository)
            : base(repository) { }
    }

    public interface IEscolaridadeService : IService<Escolaridade>
    {

    }
}

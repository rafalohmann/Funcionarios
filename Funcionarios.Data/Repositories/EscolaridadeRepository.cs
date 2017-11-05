

using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class EscolaridadeRepository : RepositoryBase<Escolaridade>, IEscolaridadeRepository
    {
        public EscolaridadeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IEscolaridadeRepository : IRepository<Escolaridade>
    {

    }
}

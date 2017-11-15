            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ICidadeRepository : IRepository<Cidade>
    {

    }
}

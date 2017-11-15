            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class FeriasRepository : BaseRepository<Ferias>, IFeriasRepository
    {
        public FeriasRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IFeriasRepository : IRepository<Ferias>
    {

    }
}

            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class ExameRepository : BaseRepository<Exame>, IExameRepository
    {
        public ExameRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IExameRepository : IRepository<Exame>
    {

    }
}

            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class ResultadoExameRepository : BaseRepository<ResultadoExame>, IResultadoExameRepository
    {
        public ResultadoExameRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IResultadoExameRepository : IRepository<ResultadoExame>
    {

    }
}

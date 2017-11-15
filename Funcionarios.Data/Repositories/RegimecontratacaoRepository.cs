            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class RegimeContratacaoRepository : BaseRepository<RegimeContratacao>, IRegimeContratacaoRepository
    {
        public RegimeContratacaoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IRegimeContratacaoRepository : IRepository<RegimeContratacao>
    {

    }
}

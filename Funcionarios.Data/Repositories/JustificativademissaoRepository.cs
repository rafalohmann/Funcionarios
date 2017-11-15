            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class JustificativaDemissaoRepository : BaseRepository<JustificativaDemissao>, IJustificativaDemissaoRepository
    {
        public JustificativaDemissaoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IJustificativaDemissaoRepository : IRepository<JustificativaDemissao>
    {

    }
}

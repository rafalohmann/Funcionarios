            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class SexoRepository : BaseRepository<Sexo>, ISexoRepository
    {
        public SexoRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ISexoRepository : IRepository<Sexo>
    {

    }
}

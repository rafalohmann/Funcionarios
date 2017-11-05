            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class PeriodoAquisitivoFeriasRepository : RepositoryBase<PeriodoAquisitivoFerias>, IPeriodoAquisitivoFeriasRepository
    {
        public PeriodoAquisitivoFeriasRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IPeriodoAquisitivoFeriasRepository : IRepository<PeriodoAquisitivoFerias>
    {

    }
}

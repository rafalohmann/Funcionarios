            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IFuncionarioRepository : IRepository<Funcionario>
    {

    }
}

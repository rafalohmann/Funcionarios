            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class FuncionarioRepository : RepositoryBase<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IFuncionarioRepository : IRepository<Funcionario>
    {

    }
}

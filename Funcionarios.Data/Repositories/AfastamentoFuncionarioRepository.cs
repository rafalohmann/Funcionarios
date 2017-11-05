using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class AfastamentoFuncionarioRepository : RepositoryBase<AfastamentoFuncionario>, IAfastamentoFuncionarioRepository
    {
        public AfastamentoFuncionarioRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IAfastamentoFuncionarioRepository : IRepository<AfastamentoFuncionario>
    {

    }
}

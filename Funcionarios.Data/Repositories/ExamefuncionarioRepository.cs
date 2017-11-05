            
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Data.Repositories
{
    class ExameFuncionarioRepository : RepositoryBase<ExameFuncionario>, IExameFuncionarioRepository
    {
        public ExameFuncionarioRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IExameFuncionarioRepository : IRepository<ExameFuncionario>
    {

    }
}

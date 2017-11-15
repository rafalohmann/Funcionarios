                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class ExameFuncionarioService : BaseService<ExameFuncionario>, IExameFuncionarioService
    {
        public ExameFuncionarioService(IRepository<ExameFuncionario> repository)
            : base(repository) { }
    }

    public interface IExameFuncionarioService : IService<ExameFuncionario>
    {

    }
}

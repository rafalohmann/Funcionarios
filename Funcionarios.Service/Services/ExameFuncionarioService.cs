                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class ExameFuncionarioService : ServiceBase<ExameFuncionario>, IExameFuncionarioService
    {
        public ExameFuncionarioService(RepositoryBase<ExameFuncionario> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IExameFuncionarioService : IService<ExameFuncionario>
    {

    }
}

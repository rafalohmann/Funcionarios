using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class AfastamentoFuncionarioService : ServiceBase<AfastamentoFuncionario>, IAfastamentoFuncionarioService
    {
        public AfastamentoFuncionarioService(RepositoryBase<AfastamentoFuncionario> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IAfastamentoFuncionarioService : IService<AfastamentoFuncionario>
    {

    }
}

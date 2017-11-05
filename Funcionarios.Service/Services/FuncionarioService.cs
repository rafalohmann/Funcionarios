                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(RepositoryBase<Funcionario> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IFuncionarioService : IService<Funcionario>
    {

    }
}

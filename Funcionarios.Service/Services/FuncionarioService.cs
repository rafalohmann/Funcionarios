                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(IRepository<Funcionario> repository)
            : base(repository) { }
    }

    public interface IFuncionarioService : IService<Funcionario>
    {

    }
}

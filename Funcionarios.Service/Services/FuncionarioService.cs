using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using Funcionarios.Service.Resources;

namespace Funcionarios.Service.Services
{
    public class FuncionarioService : BaseService<Funcionario, FuncionarioResource>, IFuncionarioService
    {
        public FuncionarioService(IRepository<Funcionario> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }

        public void Delete(int id)
        {
            Funcionario entity = repository.Get(e => e.FuncionarioId == id);
            repository.Delete(entity);
        }
    }

    public interface IFuncionarioService : IService<FuncionarioResource>
    {
        void Delete(int id);
    }
}

using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using Funcionarios.Service.Resources;

namespace Funcionarios.Service.Services
{
    public class AfastamentoFuncionarioService : BaseService<AfastamentoFuncionario, AfastamentoFuncionarioResource>, IAfastamentoFuncionarioService
    {
        public AfastamentoFuncionarioService(IRepository<AfastamentoFuncionario> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }

        public void Delete(int id)
        {
            AfastamentoFuncionario entity = repository.Get(e => e.AfastamentoFuncionarioId == id);
            repository.Delete(entity);
        }
    }

    public interface IAfastamentoFuncionarioService : IService<AfastamentoFuncionarioResource>
    {
        void Delete(int id);
    }
}

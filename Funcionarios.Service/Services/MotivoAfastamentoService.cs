                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class MotivoAfastamentoService : ServiceBase<MotivoAfastamento>, IMotivoAfastamentoService
    {
        public MotivoAfastamentoService(RepositoryBase<MotivoAfastamento> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IMotivoAfastamentoService : IService<MotivoAfastamento>
    {

    }
}

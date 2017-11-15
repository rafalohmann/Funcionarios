                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class MotivoAfastamentoService : BaseService<MotivoAfastamento>, IMotivoAfastamentoService
    {
        public MotivoAfastamentoService(IRepository<MotivoAfastamento> repository)
            : base(repository) { }
    }

    public interface IMotivoAfastamentoService : IService<MotivoAfastamento>
    {

    }
}

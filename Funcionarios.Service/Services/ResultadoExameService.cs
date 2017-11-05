                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class ResultadoExameService : ServiceBase<ResultadoExame>, IResultadoExameService
    {
        public ResultadoExameService(RepositoryBase<ResultadoExame> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IResultadoExameService : IService<ResultadoExame>
    {

    }
}

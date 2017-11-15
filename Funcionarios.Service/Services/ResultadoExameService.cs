                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class ResultadoExameService : BaseService<ResultadoExame>, IResultadoExameService
    {
        public ResultadoExameService(IRepository<ResultadoExame> repository)
            : base(repository) { }
    }

    public interface IResultadoExameService : IService<ResultadoExame>
    {

    }
}

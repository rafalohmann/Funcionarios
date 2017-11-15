                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class ExameService : BaseService<Exame>, IExameService
    {
        public ExameService(IRepository<Exame> repository)
            : base(repository) { }
    }

    public interface IExameService : IService<Exame>
    {

    }
}

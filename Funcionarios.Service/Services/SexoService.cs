                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class SexoService : BaseService<Sexo>, ISexoService
    {
        public SexoService(IRepository<Sexo> repository)
            : base(repository) { }
    }

    public interface ISexoService : IService<Sexo>
    {

    }
}

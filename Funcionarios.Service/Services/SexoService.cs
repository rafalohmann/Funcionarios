                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class SexoService : ServiceBase<Sexo>, ISexoService
    {
        public SexoService(RepositoryBase<Sexo> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface ISexoService : IService<Sexo>
    {

    }
}

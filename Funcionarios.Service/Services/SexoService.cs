using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using Funcionarios.Service.Resources;

namespace Funcionarios.Service.Services
{
    public class SexoService : BaseService<Sexo, SexoResource>, ISexoService
    {
        public SexoService(IRepository<Sexo> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }

        public void Delete(string id)
        {
            Sexo entity = repository.Get(e => e.SexoId == id);
            repository.Delete(entity);
        }
    }

    public interface ISexoService : IService<SexoResource>
    {
        void Delete(string id);
    }
}

                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class PeriodoAquisitivoFeriasService : ServiceBase<PeriodoAquisitivoFerias>, IPeriodoAquisitivoFeriasService
    {
        public PeriodoAquisitivoFeriasService(RepositoryBase<PeriodoAquisitivoFerias> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IPeriodoAquisitivoFeriasService : IService<PeriodoAquisitivoFerias>
    {

    }
}

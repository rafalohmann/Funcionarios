                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class PeriodoAquisitivoFeriasService : BaseService<PeriodoAquisitivoFerias>, IPeriodoAquisitivoFeriasService
    {
        public PeriodoAquisitivoFeriasService(IRepository<PeriodoAquisitivoFerias> repository)
            : base(repository) { }
    }

    public interface IPeriodoAquisitivoFeriasService : IService<PeriodoAquisitivoFerias>
    {

    }
}

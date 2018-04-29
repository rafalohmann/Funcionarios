using AutoMapper;
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using Funcionarios.Service.Resources;
using System.Collections.Generic;
using System.Linq;

namespace Funcionarios.Service.Services
{
    public class EstadoService : BaseService<Estado, EstadoResource>, IEstadoService
    {
        public EstadoService(IRepository<Estado> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }

        public void Delete(string id)
        {
            Estado entity = repository.Get(e => e.EstadoId == id);
            repository.Delete(entity);

            unitOfWork.Commit();
        }

        public EstadoResource Get(string id)
        {
            var entity = repository.Get(e => e.EstadoId == id);
            return Mapper.Map<Estado, EstadoResource>(entity);
        }

        public IEnumerable<EstadoResource> GetMany(EstadoResource entityResource)
        {
            if (entityResource == null)
                entityResource = new EstadoResource();

            if (entityResource.Nome == null)
                entityResource.Nome = string.Empty;

            var result = repository.GetMany(e => e.Nome.Contains(entityResource.Nome)).ToList();

            return Mapper.Map<IEnumerable<Estado>, IEnumerable<EstadoResource>>(result);
        }
    }

    public interface IEstadoService : IService<EstadoResource>
    {
        void Delete(string id);
        EstadoResource Get(string id);
        IEnumerable<EstadoResource> GetMany(EstadoResource estadoResource);
    }
}

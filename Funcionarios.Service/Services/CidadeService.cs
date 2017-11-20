using AutoMapper;
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using Funcionarios.Service.Resources;
using System.Collections.Generic;
using System.Linq;

namespace Funcionarios.Service.Services
{
    public class CidadeService : BaseService<Cidade, CidadeResource>, ICidadeService
    {
        public CidadeService(IRepository<Cidade> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }

        public void Delete(int id)
        {
            Cidade entity = repository.Get(e => e.CidadeId == id);
            repository.Delete(entity);
        }

        public CidadeResource Get(int id)
        {
            var entity = repository.Get(e => e.CidadeId == id);
            return Mapper.Map<Cidade, CidadeResource>(entity);
        }

        public IEnumerable<CidadeResource> GetMany(string EstadoId, CidadeResource entityResource)
        {
            if (entityResource == null)
                entityResource = new CidadeResource();

            if (entityResource.Nome == null)
                entityResource.Nome = string.Empty;

            var result = repository.GetMany(e => 
                e.EstadoId == EstadoId && 
                e.Nome.Contains(entityResource.Nome)
            ).ToList();
            return Mapper.Map<IEnumerable<Cidade>, IEnumerable<CidadeResource>>(result);
        }
    }

    public interface ICidadeService : IService<CidadeResource>
    {
        void Delete(int id);
        CidadeResource Get(int id);
        IEnumerable<CidadeResource> GetMany(string EstadoId, CidadeResource estadoResource);
    }
}
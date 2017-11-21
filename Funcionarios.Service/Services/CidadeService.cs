using AutoMapper;
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using Funcionarios.Service.Querys;
using Funcionarios.Service.Resources;
using System.Collections.Generic;
using System.Data.Entity;
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

        public IEnumerable<CidadeResource> GetMany(string EstadoId, CidadeQuery entityQuery)
        {
            if (entityQuery == null)
                entityQuery = new CidadeQuery();

            if (entityQuery.Nome == null)
                entityQuery.Nome = string.Empty;

            var query = repository.GetMany(e =>
                e.EstadoId == EstadoId &&
                e.CidadeId >= entityQuery.CidadeId &&
                e.Nome.Contains(entityQuery.Nome) &&
                (entityQuery.IncluirInativos || !e.Inativo)
            )
            .Include(v => v.Estado);

            switch (entityQuery.Ordenacao)
            {
                case "id":
                    query = query.OrderBy(s => s.CidadeId);
                    break;
                case "id_desc":
                    query = query.OrderByDescending(s => s.CidadeId);
                    break;
                case "estado_id":
                    query = query.OrderBy(s => s.EstadoId);
                    break;
                case "estado_id_desc":
                    query = query.OrderByDescending(s => s.EstadoId);
                    break;
                case "nome_desc":
                    query = query.OrderByDescending(s => s.Nome);
                    break;
                default:
                    query = query.OrderBy(s => s.Nome);
                    break;
            }

            query = entityQuery.AplicaPaginacao(query);

            return Mapper.Map<IEnumerable<Cidade>, IEnumerable<CidadeResource>>(query.ToList());
        }
    }

    public interface ICidadeService : IService<CidadeResource>
    {
        void Delete(int id);
        CidadeResource Get(int id);
        IEnumerable<CidadeResource> GetMany(string EstadoId, CidadeQuery entityQuery);
    }
}
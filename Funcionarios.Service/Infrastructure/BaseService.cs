using AutoMapper;
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Funcionarios.Service.Infrastructure
{
    public abstract class BaseService<T, TResource> 
        where T : BaseEntity
        where TResource : BaseResource
    {
        public readonly IRepository<T> repository;

        protected BaseService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        #region Implementation
        public virtual void Add(TResource entityResource)
        {
            T entity = Mapper.Map<TResource, T>(entityResource);
            repository.Add(entity);
        }

        public virtual void Update(TResource entityResource)
        {
            T entity = Mapper.Map<TResource, T>(entityResource);
            repository.Update(entity);
        }

        public virtual void Delete(TResource entityResource)
        {
            T entity = Mapper.Map<TResource, T>(entityResource);
            repository.Delete(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            repository.Delete(where);
        }

        public virtual TResource GetById(int id)
        {
            var entity = repository.GetById(id);
            return Mapper.Map<T, TResource>(entity);
        }

        public TResource Get(Expression<Func<T, bool>> where)
        {
            var entity = repository.Get(where);
            return Mapper.Map<T, TResource>(entity);
        }

        public virtual IEnumerable<TResource> GetAll()
        {
            var result = repository.GetAll().ToList();
            return Mapper.Map<IEnumerable<T>, IEnumerable<TResource>>(result);
        }

        public virtual IEnumerable<TResource> GetMany(Expression<Func<T, bool>> where)
        {
            var result = repository.GetMany(where).ToList();
            return Mapper.Map<IEnumerable<T>, IEnumerable<TResource>>(result);
        }
        #endregion

    }
}

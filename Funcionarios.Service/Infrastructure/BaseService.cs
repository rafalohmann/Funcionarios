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
        public readonly IUnitOfWork unitOfWork;

        protected BaseService(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public virtual void Add(TResource entityResource)
        {
            T entity = Mapper.Map<TResource, T>(entityResource);
            repository.Add(entity);

            unitOfWork.Commit();
        }

        public virtual void Update(TResource entityResource)
        {
            T entity = Mapper.Map<TResource, T>(entityResource);
            repository.Update(entity);

            unitOfWork.Commit();
        }

        public virtual void Delete(TResource entityResource)
        {
            T entity = Mapper.Map<TResource, T>(entityResource);
            repository.Delete(entity);

            unitOfWork.Commit();
        }

        public virtual TResource GetById(int id)
        {
            var entity = repository.GetById(id);
            return Mapper.Map<T, TResource>(entity);
        }

        public virtual IEnumerable<TResource> GetAll()
        {
            var result = repository.GetAll().ToList();
            return Mapper.Map<IEnumerable<T>, IEnumerable<TResource>>(result);
        }

        public void Save()
        {
            unitOfWork.Commit();
        }
        #endregion

    }
}

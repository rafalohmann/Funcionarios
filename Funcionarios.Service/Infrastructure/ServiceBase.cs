using Funcionarios.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Funcionarios.Data.Infrastructure
{
    public abstract class ServiceBase<T> where T : EntityBase
    {
        private readonly RepositoryBase<T> repository;
        private readonly IUnitOfWork unitOfWork;

        protected ServiceBase(RepositoryBase<T> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            repository.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            repository.Delete(where);
        }

        public virtual T GetById(int id)
        {
            return repository.GetById(id);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return repository.Get(where);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return repository.GetMany(where);
        }

        public virtual void Save()
        {
            unitOfWork.Commit();
        }
        #endregion

    }
}

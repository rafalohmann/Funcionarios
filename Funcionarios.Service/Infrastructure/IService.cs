using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Funcionarios.Data.Infrastructure
{
    public interface IService<TResource>
        where TResource : class
    {
        void Add(TResource resource);
        void Update(TResource resource);
        void Delete(TResource resource);
        TResource GetById(int id);
        IEnumerable<TResource> GetAll();
    }
}

using Funcionarios.Domain.Base;
using System;
using System.Linq;

namespace Funcionarios.Service.Infrastructure
{
    public abstract class BaseQuery
    {
        public virtual string Ordenacao { get; set; }
        public virtual int NumeroPagina { get; set; }
        public virtual int QuantidadePorPagina { get; set; }

        public virtual IQueryable<T> AplicaPaginacao<T>(IQueryable<T> query) 
            where T : BaseEntity
        {
            if (NumeroPagina > 0 && QuantidadePorPagina > 0)
                return query.Skip(QuantidadePorPagina * (NumeroPagina - 1)).Take(QuantidadePorPagina);

            return query;
        }
    }
}

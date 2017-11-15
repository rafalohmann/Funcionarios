using System;

namespace Funcionarios.Service.Infrastructure
{
    public abstract class BaseResource
    {
        public virtual DateTime? DataCriacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
    }
}

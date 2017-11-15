using System;

namespace Funcionarios.Domain.Base
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            DataCriacao = DateTime.Now;
        }

        public virtual DateTime? DataCriacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
    }
}

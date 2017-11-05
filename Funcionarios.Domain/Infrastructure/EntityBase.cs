using System;

namespace Funcionarios.Domain.Base
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            DataCriacao = DateTime.Now;
        }

        public virtual DateTime? DataCriacao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
    }
}

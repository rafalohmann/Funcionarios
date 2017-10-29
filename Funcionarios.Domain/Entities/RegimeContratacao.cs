using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    class RegimeContratacao : BaseEntity
    {
        public int RegimeContratacaoId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

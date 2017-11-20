using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class RegimeContratacao : BaseEntity
    {
        public int RegimeContratacaoId { get; set; }
        public string Descricao { get; set; }
        public bool Inativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

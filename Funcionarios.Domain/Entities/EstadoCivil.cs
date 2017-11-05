using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class EstadoCivil : EntityBase
    {
        public int EstadoCivilId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

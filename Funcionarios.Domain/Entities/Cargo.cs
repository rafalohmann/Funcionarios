using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class Cargo : BaseEntity
    {
        public int CargoId { get; set; }
        public string Descricao { get; set; }
        public bool Inativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    class Sexo : BaseEntity
    {
        public string SexoId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

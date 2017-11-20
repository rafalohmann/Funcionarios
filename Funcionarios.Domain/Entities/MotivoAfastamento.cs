using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class MotivoAfastamento : BaseEntity
    {
        public int MotivoAfastamentoId { get; set; }
        public string Descricao { get; set; }
        public bool Inativo { get; set; }

        public virtual List<AfastamentoFuncionario> AfastamentosFuncionario { get; set; }
    }
}

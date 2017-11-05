using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class MotivoAfastamento : EntityBase
    {
        public int MotivoAfastamentoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public virtual List<AfastamentoFuncionario> AfastamentosFuncionario { get; set; }
    }
}

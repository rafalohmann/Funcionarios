using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class Cidade : BaseEntity
    {
        public int CidadeId { get; set; }
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public Estado Estado { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

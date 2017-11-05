using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class JustificativaDemissao : EntityBase
    {
        public int JustificativaDemissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

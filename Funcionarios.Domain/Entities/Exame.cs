using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    class Exame : BaseEntity
    {
        public int ExameId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public virtual List<ExameFuncionario> ExamesFuncionario { get; set; }
    }
}

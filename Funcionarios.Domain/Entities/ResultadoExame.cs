using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class ResultadoExame : BaseEntity
    {
        public int ResultadoExameId { get; set; }
        public string Descricao { get; set; }
        public bool Inativo { get; set; }

        public virtual List<ExameFuncionario> ExamesFuncionario { get; set; }
    }
}

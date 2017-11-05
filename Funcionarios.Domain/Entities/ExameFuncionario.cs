using Funcionarios.Domain.Base;
using System;

namespace Funcionarios.Domain.Entities
{
    public class ExameFuncionario : EntityBase
    {
        public int ExameFuncionarioId { get; set; }
        public int FuncionarioId { get; set; }
        public int ExameId { get; set; }
        public int ResultadoExameId { get; set; }
        public DateTime? DataExame { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

        public Funcionario Funcionario { get; set; }
        public Exame Exame { get; set; }
        public ResultadoExame ResultadoExame { get; set; }
    }
}

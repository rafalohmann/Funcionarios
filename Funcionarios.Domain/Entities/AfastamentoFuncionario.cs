using Funcionarios.Domain.Base;
using System;

namespace Funcionarios.Domain.Entities
{
    public class AfastamentoFuncionario : BaseEntity
    {
        public int AfastamentoFuncionarioId { get; set; }
        public int FuncionarioId { get; set; }
        public int MotivoAfastamentoId { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public Funcionario Funcionario { get; set; }
        public MotivoAfastamento MotivoAfastamento { get; set; }
    }
}

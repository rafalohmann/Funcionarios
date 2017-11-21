using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Querys
{
    public class AfastamentoFuncionarioQuery: BaseQuery
    {
        public int AfastamentoFuncionarioId { get; set; }
        public int MotivoAfastamentoId { get; set; }
        public string Descricao { get; set; }
        public bool IncluirInativos { get; set; }
    }
}

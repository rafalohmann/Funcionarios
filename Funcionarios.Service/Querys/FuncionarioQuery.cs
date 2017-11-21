using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Querys
{
    public class FuncionarioQuery : BaseQuery
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public bool IncluirInativos { get; set; }
    }
}

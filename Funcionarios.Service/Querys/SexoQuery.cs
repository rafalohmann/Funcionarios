using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Querys
{
    public class SexoQuery : BaseQuery
    {
        public string SexoId { get; set; }
        public string Descricao { get; set; }
        public bool IncluirInativos { get; set; }
    }
}

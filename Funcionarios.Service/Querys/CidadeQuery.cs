using Funcionarios.Service.Infrastructure;

namespace Funcionarios.Service.Querys
{
    public class CidadeQuery : BaseQuery
    {
        public int CidadeId { get; set; }
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool IncluirInativos { get; set; }
    }
}

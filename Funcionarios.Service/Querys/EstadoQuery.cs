using Funcionarios.Service.Infrastructure;

namespace Funcionarios.Service.Querys
{
    public class EstadoQuery : BaseQuery
    {
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool IncluirInativos { get; set; }
    }
}

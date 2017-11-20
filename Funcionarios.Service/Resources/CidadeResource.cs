using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Resources
{
    public class CidadeResource : BaseResource
    {
        public int CidadeId { get; set; }
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool Inativo { get; set; }
    }
}

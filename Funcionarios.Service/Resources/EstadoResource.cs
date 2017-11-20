using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Resources
{
    public class EstadoResource : BaseResource
    {
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool Inativo { get; set; }
    }
}

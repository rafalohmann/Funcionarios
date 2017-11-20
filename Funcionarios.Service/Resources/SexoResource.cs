using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Resources
{
    public class SexoResource : BaseResource
    {
        public string SexoId { get; set; }
        public string Descricao { get; set; }
        public bool Inativo { get; set; }
    }
}

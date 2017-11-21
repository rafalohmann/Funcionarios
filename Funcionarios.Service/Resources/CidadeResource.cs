using Funcionarios.Domain.Entities;
using Funcionarios.Service.Infrastructure;
using System.Collections.Generic;

namespace Funcionarios.Service.Resources
{
    public class CidadeResource : BaseResource
    {
        public int CidadeId { get; set; }
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool Inativo { get; set; }

        public EstadoResource Estado { get; set; }
    }
}

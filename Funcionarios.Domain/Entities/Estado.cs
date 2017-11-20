using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class Estado : BaseEntity
    {
        public string EstadoId { get; set; }
        public string Nome { get; set; }
        public bool Inativo { get; set; }

        public virtual List<Cidade> Cidades { get; set; }
        public virtual List<Funcionario> FuncionariosEmissorRG { get; set; }
        public virtual List<Funcionario> FuncionariosCarteiraTrabalho { get; set; }
        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}
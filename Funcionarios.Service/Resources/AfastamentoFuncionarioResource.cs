using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Resources
{
    public class AfastamentoFuncionarioResource: BaseResource
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public int MotivoAfastamentoId { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}

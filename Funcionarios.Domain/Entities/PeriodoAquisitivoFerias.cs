using Funcionarios.Domain.Base;
using System;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    class PeriodoAquisitivoFerias : BaseEntity
    {
        public int PeriodoAquisitivoFeriasId { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool Abono { get; set; }
        public int Saldo { get; set; }
        public bool Encerrado { get; set; }
        public bool Ativo { get; set; }

        public Funcionario Funcionario { get; set; }
        public virtual List<Ferias> Feriass { get; set; }
    }
}

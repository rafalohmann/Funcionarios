﻿using Funcionarios.Domain.Base;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    class Escolaridade : BaseEntity
    {
        public int EscolaridadeId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public virtual List<Funcionario> Funcionarios { get; set; }
    }
}

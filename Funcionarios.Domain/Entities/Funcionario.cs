using Funcionarios.Domain.Base;
using System;
using System.Collections.Generic;

namespace Funcionarios.Domain.Entities
{
    public class Funcionario : BaseEntity
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public string OrgaoEmissorRG { get; set; }
        public string EstadoEmissorRGId { get; set; }
        public DateTime? DataEmissaoRG { get; set; }
        public string SexoId { get; set; }
        public int EstadoCivilId { get; set; }
        public string EscolaridadeId { get; set; }
        public DateTime? DataNascimento { get; set; }

        public int CarteiraTrabalho { get; set; }
        public int SerieCarteiraTrabalho { get; set; }
        public string LocalCarteiraTrabalho { get; set; }
        public string EstadoCarteiraTrabalhoId { get; set; }
        public DateTime? DataEmissaoCarteiraTrabalho { get; set; }

        public int CargoId { get; set; }
        public int CargaHoraria { get; set; }
        public int RegimeContratacaoId { get; set; }

        public DateTime? DataDemissao { get; set; }
        public int JustificativaDemissaoId { get; set; }
        public string RelatorioDesligamento { get; set; }

        public string EstadoId { get; set; }
        public int CidadeId { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public bool Ativo { get; set; }

        public Estado EstadoEmissorRG { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Escolaridade Escolaridade { get; set; }
        public Estado EstadoCarteiraTrabalho { get; set; }
        public Cargo Cargo { get; set; }
        public RegimeContratacao RegimeContratacao { get; set; }
        public JustificativaDemissao JustificativaDemissao { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }

        public virtual List<AfastamentoFuncionario> AfastamentosFuncionario { get; set; }
        public virtual List<ExameFuncionario> ExamesFuncionario { get; set; }
        public virtual List<Ferias> Feriass { get; set; }
    }
}

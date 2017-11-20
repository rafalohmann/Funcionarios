using Funcionarios.Service.Infrastructure;
using System;

namespace Funcionarios.Service.Resources
{
    public class FuncionarioResource : BaseResource
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

        public bool Inativo { get; set; }
    }
}

using AutoMapper;
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Base;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Resources;
using System.Collections.Generic;

namespace Funcionarios.Service.Infrastructure
{
    class DomainToResourceMappingProfile : Profile
    {
        public DomainToResourceMappingProfile()
        {
            CreateMap<AfastamentoFuncionario, AfastamentoFuncionarioResource>();
            CreateMap<Estado, EstadoResource>();
        }
    }
}

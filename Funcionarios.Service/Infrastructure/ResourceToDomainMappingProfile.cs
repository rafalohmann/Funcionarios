using AutoMapper;
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Base;
using Funcionarios.Domain.Entities;
using Funcionarios.Service.Resources;

namespace Funcionarios.Service.Infrastructure
{
    public class ResourceToDomainMappingProfile : Profile
    {
        public ResourceToDomainMappingProfile()
        {
            CreateMap<AfastamentoFuncionarioResource, AfastamentoFuncionario> ();
            CreateMap<EstadoResource, Estado>();
        }
    }
}
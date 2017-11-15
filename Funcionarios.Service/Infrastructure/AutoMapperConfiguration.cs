using AutoMapper;

namespace Funcionarios.Service.Infrastructure
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToResourceMappingProfile>();
                x.AddProfile<ResourceToDomainMappingProfile>();
            });
        }
    }
}

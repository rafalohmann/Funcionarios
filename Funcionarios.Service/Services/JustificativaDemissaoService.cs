                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class JustificativaDemissaoService : BaseService<JustificativaDemissao>, IJustificativaDemissaoService
    {
        public JustificativaDemissaoService(IRepository<JustificativaDemissao> repository)
            : base(repository) { }
    }

    public interface IJustificativaDemissaoService : IService<JustificativaDemissao>
    {

    }
}

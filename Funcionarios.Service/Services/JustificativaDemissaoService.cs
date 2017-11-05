                
using Funcionarios.Data.Infrastructure;
using Funcionarios.Domain.Entities;

namespace Funcionarios.Service.Services
{
    class JustificativaDemissaoService : ServiceBase<JustificativaDemissao>, IJustificativaDemissaoService
    {
        public JustificativaDemissaoService(RepositoryBase<JustificativaDemissao> repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork) { }
    }

    public interface IJustificativaDemissaoService : IService<JustificativaDemissao>
    {

    }
}

using System;

namespace Funcionarios.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        FuncionariosEntities Init();
    }
}

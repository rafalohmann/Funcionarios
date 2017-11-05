namespace Funcionarios.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        FuncionariosEntities dbContext;

        public FuncionariosEntities Init()
        {
            return dbContext ?? (dbContext = new FuncionariosEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

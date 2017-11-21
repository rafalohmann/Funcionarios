using Funcionarios.Api.App_Start;
using Funcionarios.Data.Infrastructure;
using System.Web.Http;

namespace Funcionarios.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init database
            System.Data.Entity.Database.SetInitializer(new SeedData());

            Bootstrapper.Run();
			
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //HttpConfiguration config = GlobalConfiguration.Configuration;
            //config.Formatters.JsonFormatter
            //            .SerializerSettings
            //            .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}

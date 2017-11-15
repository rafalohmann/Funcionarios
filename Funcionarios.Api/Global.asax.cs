using Funcionarios.Api.App_Start;
using System.Web.Http;

namespace Funcionarios.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.Run();
			
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}

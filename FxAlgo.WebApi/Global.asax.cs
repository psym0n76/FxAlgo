using System.Web.Http;

namespace FxAlgo.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //this one line works
            //Mapper.Initialize(c => c.AddProfile<PriceMappingProfile>());


            GlobalConfiguration.Configure(WebApiConfig.Register);

        }
    }
}

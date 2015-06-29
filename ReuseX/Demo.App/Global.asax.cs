using System.Web.Http;
using System.Web.Routing;

namespace Demo.App
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start( )
        {
            WebApiConfig.Register( );
        }
    }
}
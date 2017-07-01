using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Joing.Web.Startup))]
namespace Joing.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

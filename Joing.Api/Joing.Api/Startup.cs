using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Joing.Api.Startup))]

namespace Joing.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

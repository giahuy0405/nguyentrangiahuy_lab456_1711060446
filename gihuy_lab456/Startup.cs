using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gihuy_lab456.Startup))]
namespace gihuy_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

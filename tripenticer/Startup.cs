using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tripenticer.Startup))]
namespace tripenticer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

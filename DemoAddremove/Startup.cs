using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAddremove.Startup))]
namespace DemoAddremove
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

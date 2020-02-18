using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elevate_Mall_System.Startup))]
namespace Elevate_Mall_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

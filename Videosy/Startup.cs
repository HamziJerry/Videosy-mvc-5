using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Videosy.Startup))]
namespace Videosy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

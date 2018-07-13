using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Celeste.Startup))]
namespace Celeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AulaAspNetMVCModulo1.Startup))]
namespace AulaAspNetMVCModulo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

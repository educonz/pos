using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExercicioCorreio.Startup))]
namespace ExercicioCorreio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

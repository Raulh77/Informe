using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Informe.Startup))]
namespace Informe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

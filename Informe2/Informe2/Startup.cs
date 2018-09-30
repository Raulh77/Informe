using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Informe2.Startup))]
namespace Informe2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

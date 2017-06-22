using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba.web.Startup))]
namespace Prueba.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vazar.Startup))]
namespace Vazar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

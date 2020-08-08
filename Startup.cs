using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PNTS.Startup))]
namespace PNTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

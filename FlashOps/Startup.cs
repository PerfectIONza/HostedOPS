using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashOps.Startup))]
namespace FlashOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

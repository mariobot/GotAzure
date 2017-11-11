using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GotAzure.Startup))]
namespace GotAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PriceMaintain.Startup))]
namespace PriceMaintain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

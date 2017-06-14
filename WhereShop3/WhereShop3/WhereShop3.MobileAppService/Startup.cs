using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WhereShop3.MobileAppService.Startup))]

namespace WhereShop3.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
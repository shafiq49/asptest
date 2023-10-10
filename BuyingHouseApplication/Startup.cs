using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuyingHouseApplication.Startup))]
namespace BuyingHouseApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

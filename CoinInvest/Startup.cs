using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoinInvest.Startup))]
namespace CoinInvest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

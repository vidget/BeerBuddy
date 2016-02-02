using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerBuddy.Startup))]
namespace BeerBuddy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

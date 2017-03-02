using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inventory2.Startup))]
namespace Inventory2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

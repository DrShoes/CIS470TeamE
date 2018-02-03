using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS470TeamE.Startup))]
namespace CIS470TeamE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

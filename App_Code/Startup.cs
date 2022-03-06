using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRAPP.Startup))]
namespace HRAPP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

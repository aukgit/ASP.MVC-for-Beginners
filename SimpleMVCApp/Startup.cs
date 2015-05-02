using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleMVCApp.Startup))]
namespace SimpleMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

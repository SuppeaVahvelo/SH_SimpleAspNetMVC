using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAspNetMVC.Startup))]
namespace SimpleAspNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

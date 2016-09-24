using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dev_1.Web.Startup))]
namespace dev_1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

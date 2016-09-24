using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(de_1.Web.Startup))]
namespace de_1.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bazzar.Web.Startup))]
namespace Bazzar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

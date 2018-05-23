using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiNet.Web.Startup))]
namespace PiNet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

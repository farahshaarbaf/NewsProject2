using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_Web.Startup))]
namespace New_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

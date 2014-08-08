using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogProjectRedeux.Web.Startup))]
namespace BlogProjectRedeux.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

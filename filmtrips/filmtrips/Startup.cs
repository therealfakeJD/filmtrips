using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(filmtrips.Startup))]
namespace filmtrips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APP_BEER_ME.Startup))]
namespace APP_BEER_ME
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

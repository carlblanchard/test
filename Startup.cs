using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_Hub_Test.Startup))]
namespace Git_Hub_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

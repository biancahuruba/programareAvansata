using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCurs8.Startup))]
namespace MVCCurs8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

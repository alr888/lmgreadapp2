using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lmgreadapp2.Startup))]
namespace lmgreadapp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

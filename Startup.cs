using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MZ2247A6.Startup))]

namespace MZ2247A6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

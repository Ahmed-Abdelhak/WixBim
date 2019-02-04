using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WixBix.Startup))]
namespace WixBix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

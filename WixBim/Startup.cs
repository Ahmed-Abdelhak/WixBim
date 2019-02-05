using Microsoft.Owin;
using Owin;
using WixBim;

[assembly: OwinStartup(typeof(Startup))]
namespace WixBim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

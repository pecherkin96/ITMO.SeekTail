using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITMO.SeekTail.Startup))]
namespace ITMO.SeekTail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

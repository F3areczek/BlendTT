using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlendTT.Startup))]
namespace BlendTT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiufangShowcase.Startup))]
namespace LiufangShowcase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

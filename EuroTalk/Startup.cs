using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EuroTalk.Startup))]
namespace EuroTalk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

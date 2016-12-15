using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyEventManager.Startup))]
namespace MyEventManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

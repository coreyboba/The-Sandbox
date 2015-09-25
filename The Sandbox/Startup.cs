using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(The_Sandbox.Startup))]
namespace The_Sandbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

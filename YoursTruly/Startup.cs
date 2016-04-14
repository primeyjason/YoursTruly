using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YoursTruly.Startup))]
namespace YoursTruly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

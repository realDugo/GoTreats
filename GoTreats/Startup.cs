using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoTreats.Startup))]
namespace GoTreats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(edman_project.Startup))]
namespace edman_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

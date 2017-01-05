using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoGit.MVC.Startup))]
namespace DemoGit.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VsGitTest.Startup))]
namespace VsGitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

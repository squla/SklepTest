using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SklepTest.Startup))]
namespace SklepTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

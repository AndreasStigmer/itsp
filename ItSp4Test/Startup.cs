using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItSp4Test.Startup))]
namespace ItSp4Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}

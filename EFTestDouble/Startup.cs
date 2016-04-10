using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFTestDouble.Startup))]
namespace EFTestDouble
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

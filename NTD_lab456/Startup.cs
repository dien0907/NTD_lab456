using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NTD_lab456.Startup))]
namespace NTD_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

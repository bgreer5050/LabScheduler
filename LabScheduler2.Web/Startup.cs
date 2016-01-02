using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabScheduler2.Web.Startup))]
namespace LabScheduler2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

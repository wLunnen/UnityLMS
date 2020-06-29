using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnityLMS.Startup))]
namespace UnityLMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

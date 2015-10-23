using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemberManagement.Web.Startup))]
namespace MemberManagement.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

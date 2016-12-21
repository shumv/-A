using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProjectOfUniversity.Startup))]
namespace WebProjectOfUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

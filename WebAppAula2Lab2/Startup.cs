using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAula2Lab2.Startup))]
namespace WebAppAula2Lab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

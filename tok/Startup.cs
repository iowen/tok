using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tok.Startup))]
namespace tok
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

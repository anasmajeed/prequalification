using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prequalification.Startup))]
namespace prequalification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

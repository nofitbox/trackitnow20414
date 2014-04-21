using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trackitnow20414.Startup))]
namespace trackitnow20414
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

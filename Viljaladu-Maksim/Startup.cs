using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Viljaladu_Maksim.Startup))]
namespace Viljaladu_Maksim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

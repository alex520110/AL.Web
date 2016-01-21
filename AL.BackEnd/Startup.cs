using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AL.BackEnd.Startup))]
namespace AL.BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

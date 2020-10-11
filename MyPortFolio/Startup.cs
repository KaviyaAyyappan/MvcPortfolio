using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPortFolio.Startup))]
namespace MyPortFolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

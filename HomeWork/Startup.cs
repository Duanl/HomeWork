using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWork.UI.Startup))]
namespace HomeWork.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

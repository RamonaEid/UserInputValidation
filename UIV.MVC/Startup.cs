using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIV.MVC.Startup))]
namespace UIV.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

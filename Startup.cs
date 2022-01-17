using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(studentMVC.Startup))]
namespace studentMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

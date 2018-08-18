using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sales.Backen.Startup))]
namespace Sales.Backen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Shopping.Startup))]
namespace E_Shopping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1811062845_PhamThanhTuan_Bigschooll.Startup))]
namespace _1811062845_PhamThanhTuan_Bigschooll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Media_X.Startup))]
namespace Media_X
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(csharpproject.Startup))]
namespace csharpproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

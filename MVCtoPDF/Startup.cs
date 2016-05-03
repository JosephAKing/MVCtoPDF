using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCtoPDF.Startup))]
namespace MVCtoPDF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

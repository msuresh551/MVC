using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCExamples.Startup))]
namespace MVCExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

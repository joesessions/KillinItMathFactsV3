using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KillinItMathFactsV3.Startup))]
namespace KillinItMathFactsV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

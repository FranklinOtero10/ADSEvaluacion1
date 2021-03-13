using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADSEvaluacion1.Startup))]
namespace ADSEvaluacion1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

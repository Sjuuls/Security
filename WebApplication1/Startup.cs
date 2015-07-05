using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HerkansingPracticum.Startup))]
namespace HerkansingPracticum
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

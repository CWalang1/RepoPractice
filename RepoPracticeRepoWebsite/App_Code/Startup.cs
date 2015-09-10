using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoPracticeRepoWebsite.Startup))]
namespace RepoPracticeRepoWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

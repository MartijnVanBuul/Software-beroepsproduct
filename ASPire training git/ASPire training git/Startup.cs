using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPire_training_git.Startup))]
namespace ASPire_training_git
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test1AzureDevops.Startup))]
namespace Test1AzureDevops
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

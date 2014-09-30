using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppharbor.Startup))]
namespace TestAppharbor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

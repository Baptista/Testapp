using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TestAppharbor.Models;

[assembly: OwinStartupAttribute(typeof(TestAppharbor.Startup))]
namespace TestAppharbor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateAdmin();
        }
        public void CreateAdmin()
        {
            

        }
    }
}

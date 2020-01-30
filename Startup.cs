using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyChoice.Startup))]
namespace MyChoice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

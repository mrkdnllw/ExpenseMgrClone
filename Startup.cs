using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpenseManagerClone.Startup))]
namespace ExpenseManagerClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

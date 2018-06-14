using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProfQuiz.Startup))]
namespace ProfQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

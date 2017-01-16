using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindExercise.Startup))]
namespace NorthwindExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

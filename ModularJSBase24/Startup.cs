using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModularJSBase24.Startup))]
namespace ModularJSBase24
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}

using System.Web;
using System.Web.Optimization;

namespace ModularJSBase24
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.UseCdn = true;

			var fontAwesomeCDNPath = "http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css";

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			bundles.Add(new StyleBundle("~/Content/fontawesome", fontAwesomeCDNPath).Include(
				 "~/Content/fontawesome.css"
				));
			bundles.Add(new ScriptBundle("~/bundles/t3").Include(
				"~/Scripts/t3.js"
				));

			bundles.Add(new ScriptBundle("~/bundles/t3_testing").Include(
				"~/Script/t3-testing.js",
				"~/Script/chai.js",
				"~/Script/sinon-1.17.2.js"
				));

			bundles.Add(new ScriptBundle("~/bundles/ajax").Include(
				"~/Scripts/modules/Ajax.js")
				);


		}
	}
}

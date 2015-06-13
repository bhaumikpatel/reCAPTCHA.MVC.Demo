using System.Web;
using System.Web.Optimization;

namespace reCAPTCHA.Web.Demo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery", "//cdn.jsdelivr.net/jquery/1.7.1/jquery.min.js").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/flatUi", "//maxcdn.bootstrapcdn.com/bootswatch/3.3.4/flatly/bootstrap.min.css")
                .Include("~/Content/Flatly/bootstrap.min.css"));

            bundles.UseCdn = false;
            BundleTable.EnableOptimizations = true;
        }
    }
}
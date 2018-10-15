using System.Web;
using System.Web.Optimization;

namespace MaPanel
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Styles
            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                      "~/Content/Styles/bootstrap.min.css",
                      "~/Content/Styles/Style.css"));

            // Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
        }
    }
}

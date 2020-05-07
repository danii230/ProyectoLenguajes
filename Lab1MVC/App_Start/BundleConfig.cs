using System.Web;
using System.Web.Optimization;

namespace Lab1MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/datatables.js",
                      "~/Scripts/dataTables.bootstrap.js",
                      "~/Scripts/dataTables.bootstrap4.js",
                      "~/Scripts/dataTables.foundation.js",
                      "~/Scripts/dataTables.jqueryui.js",
                      "~/Scripts/dataTables.semanticui.js",
                      "~/Scripts/jquery.dataTables.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/datatables.css",
                     "~/Content/dataTables.bootstrap.css",
                     "~/Content/dataTables.bootstrap4.css",
                     "~/Content/dataTables.foundation.css",
                     "~/Content/dataTables.jqueryui.css",
                     "~/Content/dataTables.semanticui.css",
                     "~/Content/jquery.dataTables.css"));
        }
    }
}

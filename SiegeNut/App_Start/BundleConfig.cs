using System.Web;
using System.Web.Optimization;

namespace SiegeNut
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://code.jquery.com/jquery-3.2.1.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapscripts", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css"));
            
            BundleTable.EnableOptimizations = true;
        }
    }
}

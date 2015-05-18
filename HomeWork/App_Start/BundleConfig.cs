using System.Web.Optimization;

namespace HomeWork.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var cssBundle = new StyleBundle("~/bundles/css");
            cssBundle.Include("~/Content/themes/bootstrap/easyui.css",
                "~/Content/themes/icon.css");
            bundles.Add(cssBundle);

            var jqueryBundle = new ScriptBundle("~/bundles/jquery");
            jqueryBundle.Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery.easyui-{version}.js");
            bundles.Add(jqueryBundle);

            var jqueryvalBundle = new ScriptBundle("~/bundles/jqueryval");
            jqueryvalBundle.Include("~/Scripts/jquery.validate*");
            bundles.Add(jqueryvalBundle);
        }
    }
}
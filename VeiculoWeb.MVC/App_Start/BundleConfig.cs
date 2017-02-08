using System.Web;
using System.Web.Optimization;

namespace VeiculoWeb.MVC
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

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Scripts/angular.js",
                     "~/Scripts/angular-locate_pt-br.js"

                     ));

            bundles.Add(new ScriptBundle("~/bundles/ngFileUpload").Include(
                     "~/Scripts/ng-file-upload-shim.min.js",
                     "~/Scripts/angular.min.js",
                     "~/Scripts/ng-file-upload.min.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                     //"~/Scripts/App/App.js",
                     //"~/Scripts/App/clienteCtrl.js"
                     "~/App/Module.js",
                     "~/App/Service.js",
                     "~/App/Controller.js"
                     ));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}

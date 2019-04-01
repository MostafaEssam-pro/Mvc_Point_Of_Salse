using System.Web;
using System.Web.Optimization;

namespace Mvc_ospos
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/pace.js",
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/popper.js",
                        "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/dataTables.bootstrap4.min.js" 
                        ));

            bundles.Add(new ScriptBundle("~/bundles/lay").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/sidenav.js",
                      "~/Scripts/layout-helpers.js",
                      "~/Scripts/material-ripple.js"
                      
                      ));

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                      "~/Scripts/perfect-scrollbar.js",
                      "~/Scripts/eve.js",
                      "~/Scripts/flot.js",
                      "~/Scripts/curvedLines.js",
                      "~/Scripts/core.js",
                      "~/Scripts/charts.js",
                      "~/Scripts/animated.js",
                      "~/Scripts/raphael.js",
                      "~/Scripts/morris.js",
                      "~/Scripts/demo.js",
                      "~/Scripts/analytics.js",
                      "~/Scripts/dashboards_ecommerce.js"
                      ));



            bundles.Add(new ScriptBundle("~/bundles/validate").Include(
                        "~/Scripts/jquery.validate.min"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //  "~/Scripts/bootstrap.js"));


         



            bundles.Add(new StyleBundle("~/Content/fonts").Include(
                      "~/fonts/fontawesome.css",
                      "~/fonts/ionicons.css",
                      "~/fonts/linearicons.css",
                      "~/fonts/open-iconic.css",
                      "~/fonts/pe-icon-7-stroke.css",
                      "~/fonts/feather.css"
                      ));



            bundles.Add(new StyleBundle("~/Content/admin").Include(
                      "~/Content/admin/bootstrap-material.css",
                      "~/Content/admin/shreerang-material.css",
                      "~/Content/admin/uikit.css.css",
                       "~/Content/dataTables.bootstrap4.min.css",

                      "~/Content/admin/perfect-scrollbar.css",
                      "~/Content/admin/flot.css"
                     
                      ));



        }
    }
}





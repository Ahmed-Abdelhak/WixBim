using System.Web.Optimization;

namespace WixBim
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
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

            //bundles.Add(new StyleBundle("~/bundles/bXbim").Include(
            // "~/Scripts/XBIM/xbim-viewer.debug.bundle.js" ,
            //     "~/Scripts/XBIM/Plugins/NavigationCube/xbim-navigation-cube.debug.js"  ,
            // "~/Scripts/XBIM/Plugins/NavigationCube/xbim-navigation-cube-shaders.debug.js"     ,
            //    "~/Scripts/XBIM/Viewer/xbim-triangulated-shape.debug.js",
            //    "~/Scripts/XBIM/Viewer/xbim-binary-reader.debug.js",
            //    "~/Scripts/XBIM/Viewer/xbim-model-handle.debug.js",
            //    "~/Scripts/XBIM/Viewer/xbim-shaders.debug.js",
            //    "~/Scripts/XBIM/Viewer/xbim-model-geometry.debug.js",
            // "~/Scripts/XBIM/Viewer/xbim-state.debug.js" ,
            // "~/Scripts/XBIM/Viewer/xbim-product-type.debug.js" ,
            // "~/Scripts/XBIM/Plugins/NavigationHome/xbim-navigation-home.debug.js" ,
            // "~/Scripts/XBIM/Plugins/NavigationHome/xbim-navigation-home-textures.debug.js" ,
            // "~/Scripts/XBIM/Plugins/NavigationCube/xbim-navigation-cube-textures.debug.js"


            //));
        }
    }
}

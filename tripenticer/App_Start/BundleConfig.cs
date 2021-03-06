﻿using System.Web;
using System.Web.Optimization;

namespace tripenticer
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery.bxslider.min.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/waypoints-min.js",
                        "~/Scripts/functions.js"
                       
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery.accordion.js",
                        "~/Scripts/jquery.circlechart.js",
                        "~/Scripts/jquery.countdown.js",
                        "~/Scripts/map.js",
                      "~/Scripts/bootstrap-progressbar.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/font-awesome.css",
                      "~/Content/color.css",
                      "~/Content/style.css",
                      "~/Content/responsive.css",
                      "~/Content/themetypo.css",
                      "~/Content/bxslider.css",
                      "~/Content/datepicker.css"           
                    ));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace HockeyTrackingApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js")
                   .Include("~/Scripts/jquery-{version}.js")
                   .IncludeDirectory("~/Scripts/app", "*.js"));
        }
    }
}
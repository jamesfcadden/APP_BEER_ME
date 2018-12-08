using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using APP_BEER_ME.DAL;
using System.Data.Entity.Infrastructure.Interception;


namespace APP_BEER_ME
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new APP_BEER_MEInterceptorTransientErrors());
            DbInterception.Add(new APP_BEER_MEInterceptorLogging());
        }
    }
}

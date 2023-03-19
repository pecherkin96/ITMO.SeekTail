using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(new PetColorDbInitializer());
            Database.SetInitializer(new AnimalDbInitializer());
            Database.SetInitializer(new LocationDbInitializer());
            Database.SetInitializer(new ShelterDbInitializer());
        }
    }
}
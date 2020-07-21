using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MiniInstagram.Database;
using MiniInstagram.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MiniInstagram.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            using (DBContext db = new DBContext())
            {
                IdentityRole adminRole = new IdentityRole()
                {
                    Name = "admin"
                };
                IdentityRole userRole = new IdentityRole()
                {
                    Name = "user"
                };
                ApplicationUser user1 = new ApplicationUser
                {
                    UserName = "NBNN"
                };
                ApplicationUser user2 = new ApplicationUser
                {
                    UserName = "NBNN1111"
                };
                db.Users.Add(user1);
                db.Users.Add(user2);

                db.Roles.Add(adminRole);
                db.Roles.Add(userRole);

                db.SaveChanges();
            }
        }
    }
}

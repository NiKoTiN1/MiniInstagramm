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
            using(DBContext db = new DBContext())
            {
                Image image1 = new Image { Path = "1234", category = Category.Other, UploadDate = DateTime.Now, User = new ApplicationUser(), Id = Guid.NewGuid() };
                Image image2 = new Image { Path = "4321", category = Category.football, UploadDate = DateTime.UtcNow, User = new ApplicationUser(), Id = Guid.NewGuid() };
                db.Images.Add(image1);
                db.Images.Add(image2);
                db.SaveChanges();
                Console.WriteLine("Success save!");

                var images = db.Images;
                foreach(Image image in images)
                {
                    Console.WriteLine(image.Path);
                }
                Console.Read();
            }
        }
    }
}

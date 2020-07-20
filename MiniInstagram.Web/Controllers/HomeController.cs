using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniInstagram.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            string connectionString = ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
            Console.WriteLine(connectionString);

            Console.Read();
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapsPrueba1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string latitud, string longitud)
        {
            ViewBag.Latitud = latitud;
            ViewBag.Longitud = longitud;


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
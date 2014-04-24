using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trackitnow20414.Models;

namespace GoogleMapsPrueba1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            //Para conseguir las ultimas coordenadas
            var coordenas = (from i in db.Coordenadas orderby i.Id descending select i).FirstOrDefault();

            ViewBag.Latitud = coordenas.Latitud;
            ViewBag.Longitud = coordenas.Longitud;
            


            return View();
        }

        [HttpGet]

        public string Create(string latitud, string longitud)
        {
            CoordenadasModels coor = new CoordenadasModels();

            coor.Latitud = latitud;
            coor.Longitud = longitud;
            coor.Fecha = DateTime.Now;
            db.Coordenadas.Add(coor);
            db.SaveChanges();

            return "1";
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
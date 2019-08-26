using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcCRUD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Aplicação ASP.NET WEB API";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dados para contato";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "opis działania kreatora wdrożeń";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "adres do firmy Test-sytem";

            return View();
        }

        public ActionResult CreatorForms()
        {
            ViewBag.Message = "Proszę o uzupełnienie formularza";

            return View();
        }
        public ActionResult go1()
        {
            ViewBag.Message = "css ";

            return View();
        }
    }
}
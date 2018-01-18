using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AADforAnExistingWebApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.Message = "Vous êtes dans une zone sécurisée / You are in a restricted area";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vous êtes dans une zone non sécurisée / You are in an unrestricted area";
            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Bienvenue! utilisateur anonyme / Welcome! anonymous user";
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleAspNetMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView("Index");
            return View("Index");

        }

        public ActionResult About()
        {
            if (Request.IsAjaxRequest())
                return PartialView("About");
            return View("About");

        }

        public ActionResult Contact()
        {
            if (Request.IsAjaxRequest())
                return PartialView("Contact");
            return View("Contact");

        }

        public ActionResult TimerPartial()
        {
            // Pass necessary data to the Timer partial view
            return PartialView("TimerPartial");
        }

        //public ActionResult Index()
        //{
        //    return PartialView("_Index");
        //}
        //[AllowAnonymous]
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return PartialView("About");
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return PartialView("Contact");
        //}
    }
    }
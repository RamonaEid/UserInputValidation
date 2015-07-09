using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIV.BL;
using UIV.MVC.Models;

namespace UIV.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserInputViewModel model)
        {
            var result = Validator.IsValid(model.InputStr);

            if (!ModelState.IsValid)
            {
                model.Result = string.Empty;
                return View(model);
            }

            if (!result)
            {
                model.Result = "Oops!  Try Again!";
                return View(model);
            }

            if (model.Counter == null)
            {
                model.Result = "Bingo!  It Validates!";
                model.Counter = "two";
            }
            else
            {
                model.Result = "You are a Winner!";
                model.Counter = null;
            }

            ProcessList(model);
            ModelState.Clear();
            return View(model);
        }

        private static void ProcessList(UserInputViewModel model)
        {
            var oldList = model.ResultList;
            if (oldList == null)
                oldList += model.InputStr;
            else
                oldList += "," + model.InputStr;
            model.ResultList = oldList;
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